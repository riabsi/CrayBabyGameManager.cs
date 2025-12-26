using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float attackRange = 1.5f;
    public Transform targetDoll; // دمية كراي بيبي المستهدفة

    void Update()
    {
        if (targetDoll != null)
        {
            // التحرك باتجاه الدمية لإنقاذها أو مطاردتها
            float distance = Vector3.Distance(transform.position, targetDoll.position);
            
            if (distance > attackRange)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetDoll.position, moveSpeed * Time.deltaTime);
            }
            else
            {
                Attack();
            }
        }
    }

    void Attack()
    {
        // منطق هجوم الوحش
        Debug.Log("The monster is attacking the Cray Baby! Use your weapons!");
    }

    // لزيادة الصعوبة في المستويات المتقدمة
    public void IncreaseDifficulty(float speedMultiplier)
    {
        moveSpeed *= speedMultiplier;
    }
}
