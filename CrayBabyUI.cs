using UnityEngine;
using UnityEngine.UI;

public class CrayBabyUI : MonoBehaviour
{
    public Text missionText;      // نص لعرض رقم المهمة (1-100)
    public Text monsterCountText; // نص لعرض عدد الوحوش المتبقية
    public Slider healthBar;     // شريط دم لدمى Cray Baby

    public void UpdateUI(int mission, int monsters, float health)
    {
        missionText.text = "Mission: " + mission + "/100";
        monsterCountText.text = "Monsters Left: " + monsters;
        healthBar.value = health;
        
        if (health <= 0)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        Debug.Log("Game Over! The forest is too dangerous. Try again, Riad!");
    }
}
