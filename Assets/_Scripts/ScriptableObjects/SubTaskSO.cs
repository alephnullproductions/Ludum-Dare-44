using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sub Task", menuName = "Sub Task")]
public class SubTaskSO : ScriptableObject {

    // 
    public string description;
    public string target;
    public GameObject mustBeDelivered;
    public float timeToComplete;


    // Type of Action Required
    public enum TaskType {
        Delivery, 
        RepairOrActivate,
        PutOutFire
    };

    public void SetupTask(TaskType ttype) {
        if (ttype == TaskType.Delivery) {
            // Setup Delivery Requirements
            // Valid Delivery Type
            
        }
        else if (ttype == TaskType.RepairOrActivate) {
            // Succeed if Activate
            
        }
        else if (ttype == TaskType.PutOutFire) {
            // Timer
            // Succeed if get there in time
            
        }
    }

}
