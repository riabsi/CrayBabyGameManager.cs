using UnityEngine;
using UnityEngine.UI; // هذا السطر مهم جداً للتعامل مع الواجهة

public class UIManager : MonoBehaviour
{
    public HealthSystem playerHealth; // نربطه بكود الصحة السابق
    public Text healthDisplay; // نص يعرض رقم الطاقة على الشاشة

    void Update()
    {
        // تحديث الرقم الظاهر على الشاشة باستمرار
        healthDisplay.text = "HP: " + playerHealth.currentHealth;
    }

    public void OnWeaponButtonClicked(string weaponName)
    {
        Debug.Log("اللاعب اختار سلاح: " + weaponName);
        // هنا يتم استدعاء كود تبديل السلاح
    }
}
