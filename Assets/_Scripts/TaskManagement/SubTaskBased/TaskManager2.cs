using System.Collections;
using System.Collections.Generic;
using GameEvents;
using UnityEngine;

public class TaskManager2 : MonoBehaviour {

    public List<IndividualTask> tasks;
    // queue created from this list of Tasks

    public bool areAllTasksComplete;
    public GameEvent allTasksComplete;
    
    // List of PlayerTasks
    //    of Type PlayerTask
    // List to Queue
    
    // Inheritance
    //    PlayerTask Abstract Class
    
    // PlayerTask - CustomType
    //    Boolean - isComplete
    //    Action...
    
    // DeliverTask - CustomType
    //    Boolean - isComplete
    //    GameObject - Pickup //PickupType        - Could be Enum
    //    GameObject - Interact //InteractType    - Could be Enum
    //    GameObject - Destination //Destination or Object
    
    // ArriveTask - CustomType
    //    Boolean - isComplete
    //    GameObject - Destination
    
    // TimedArriveTask - CustomType
    //    Boolean - isComplete
    //    GameObject - Destination
    //    int - seconds2Complete
    //    CreateCountdownTimer


    void Awake() {
//        allTasksComplete = 
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (areAllTasksComplete) {
            allTasksComplete.Raise();
        }
    }
}
