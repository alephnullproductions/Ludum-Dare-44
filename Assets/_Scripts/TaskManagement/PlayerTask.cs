using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerTask : MonoBehaviour {
    public bool isComplete;
    public GameObject destination;
    
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
}
