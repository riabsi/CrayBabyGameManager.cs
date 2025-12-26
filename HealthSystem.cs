using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // الطاقة القصوى للبطل أو الوحش
    public int maxHealth = 100; 
    public int currentHealth;

    void Start()
    {
        // تبدأ الشخصية بطاقة كاملة
        currentHealth = maxHealth;
        Debug.Log("تم تفعيل نظام الصحة. الطاقة الحالية: " + currentHealth);
    }

    // وظيفة لتلقي الضرر من الأسلحة
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("وقع ضرر! الطاقة المتبقية: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("لقد سقطت الشخصية في المعركة!");
        // هنا يمكن إضافة تأثيرات الاختفاء أو شاشة النهاية
    }
}
