using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // سرعة المشي
    public float jumpForce = 7f; // قوة القفز
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // الحصول على مكونات الفيزياء
    }

    void Update()
    {
        // التحرك يميناً ويساراً
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // القفز عند الضغط على زر القفز
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    // التأكد من أن البطل يلمس الأرض
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
