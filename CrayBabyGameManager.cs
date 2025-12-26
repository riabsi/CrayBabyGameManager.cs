using UnityEngine;
using System.Collections.Generic;

public class CrayBabyGameManager : MonoBehaviour
{
    // تعريف الشخصيات والأسلحة
    public enum WeaponType { Sword, Hammer, Pistol }
    public int currentLevel = 1;
    public int totalLevels = 100;
    
    [System.Serializable]
    public class DollCharacter {
        public string name;
        public bool isRescued = false;
        public float health = 100f;
    }

    public List<DollCharacter> crayBabies = new List<DollCharacter>();

    void Start() {
        Debug.Log("Starting Cray Baby Rescue Mission!");
        InitializeLevel(currentLevel);
    }

    // نظام إدارة المهام الـ 100
    public void InitializeLevel(int level) {
        float difficultyMultiplier = 1.0f + (level * 0.1f); // تزداد الصعوبة 10% كل مستوى
        int monsterCount = level * 2; // عدد الوحوش يزداد مع كل مهمة
        
        Debug.Log($"Mission {level}: Save the Cray Babies from {monsterCount} monsters!");
        
        // هنا يتم استدعاء الوحوش في الغابة بناءً على مستوى الصعوبة
    }

    // نظام القتال والأسلحة
    public void UseWeapon(WeaponType weapon) {
        switch (weapon) {
            case WeaponType.Sword:
                Debug.Log("Using Sword: Fast melee attack!");
                break;
            case WeaponType.Hammer:
                Debug.Log("Using Hammer: Heavy damage, slow speed!");
                break;
            case WeaponType.Pistol:
                Debug.Log("Using Pistol: Ranged attack to keep monsters away!");
                break;
        }
    }

    // التحقق من الفوز في المهمة
    public void CheckMissionStatus() {
        if (currentLevel < totalLevels) {
            currentLevel++;
            InitializeLevel(currentLevel);
        } else {
            Debug.Log("Congratulations Riad! All 100 missions complete!");
        }
    }
}
