using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    // أنواع الأسلحة المتاحة
    public enum WeaponType { Sword, Hammer, Pistol }
    public WeaponType currentWeapon;

    void Start()
    {
        // نبدأ اللعبة بالسيف كديفولت
        currentWeapon = WeaponType.Sword;
        Debug.Log("بدأت اللعبة بـ: " + currentWeapon);
    }

    public void SwitchWeapon(WeaponType newWeapon)
    {
        currentWeapon = newWeapon;
        Debug.Log("تم تبديل السلاح إلى: " + currentWeapon);
    }
}
