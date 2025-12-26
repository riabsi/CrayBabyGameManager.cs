using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public HealthSystem playerHealth; // ربط صحة البطل
    public HealthSystem enemyHealth;  // ربط صحة الوحش

    // وظيفة عندما يضرب البطل الوحش بالسيف
    public void PlayerAttack(int damage)
    {
        Debug.Log("البطل يهاجم!");
        enemyHealth.TakeDamage(damage);
    }

    // وظيفة عندما يلمس الوحش البطل
    public void EnemyAttack(int damage)
    {
        Debug.Log("الوحش يهاجم البطل!");
        playerHealth.TakeDamage(damage);
    }
}
