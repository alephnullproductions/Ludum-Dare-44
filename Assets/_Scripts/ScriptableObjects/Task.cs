using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Task", menuName = "Task")]
public class Task : ScriptableObject {
    
    // 
    public bool isCompleted;
    
    public GameObject destinationZone;
    public GameObject mustBeActivatedUsedOrRepaired;
    public GameObject mustBeDelivered;

    public float timeLimit;


    // Type of Action Required
    public enum TaskType {
        Delivery, 
        RepairOrActivate,
        PutOutFire
    };

    public void CompleteTask() {
        isCompleted = true;
    }

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
