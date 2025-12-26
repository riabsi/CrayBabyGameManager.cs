using UnityEngine;
using System.Collections.Generic;

public class MissionManager : MonoBehaviour
{
    public int currentMission = 1;
    public int totalMissions = 100;
    
    // تفاصيل كل مهمة
    [System.Serializable]
    public class MissionDetails {
        public string missionGoal;
        public int monsterCount;
        public float monsterSpeed;
    }

    void Start() {
        LoadMission(currentMission);
    }

    public void LoadMission(int missionNumber) {
        if (missionNumber <= totalMissions) {
            Debug.Log("Loading Mission #" + missionNumber);
            // زيادة الصعوبة تلقائياً
            int monsters = 5 + (missionNumber * 2); 
            float speed = 2.0f + (missionNumber * 0.1f);
            
            GenerateForest(monsters, speed);
        } else {
            Debug.Log("Amazing Riad! You saved all the Cray Babies!");
        }
    }

    void GenerateForest(int count, float speed) {
        // هنا يتم وضع الوحوش والدمى في الغابة برمجياً
        Debug.Log("Spawned " + count + " monsters with speed " + speed);
    }

    public void MissionComplete() {
        currentMission++;
        LoadMission(currentMission);
    }
}
