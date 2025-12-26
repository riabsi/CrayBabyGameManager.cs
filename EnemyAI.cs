using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 2f; // سرعة مطاردة الوحش
    public Transform player; // تحديد مكان البطل
    public float detectionRange = 10f; // مدى الرؤية للوحش

    void Update()
    {
        // حساب المسافة بين الوحش والبطل
        float distance = Vector2.Distance(transform.position, player.position);

        // إذا كان البطل قريباً، يبدأ الوحش بالمطاردة
        if (distance < detectionRange)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
            
            // تنبيه في سجل اللعبة
            Debug.Log("الوحش رصدك! إنه يقترب..");
        }
    }
}
