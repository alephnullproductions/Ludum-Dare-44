using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIObjectiveController : MonoBehaviour {

    public GameObject targetZone;

    public List<GameObject> zlist = new List<GameObject>();
    [SerializeField]
    public Queue<GameObject> Zones = new Queue<GameObject>();
    // Zones need a container object with wait duration...

    [SerializeField]
    private float dist = 100;
    private NavMeshAgent nav;
    
    private bool atZone = false;
    private bool isTraveling = false;
    
    private void Awake() {
        Zones = new Queue<GameObject>(zlist);
        nav = GetComponent<NavMeshAgent>();

        targetZone = Zones.Dequeue();
        atZone = false;
        dist = Vector3.Distance(transform.position,
            targetZone.transform.position);
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(targetZone.name);
        
        dist = Vector3.Distance(transform.position,
            targetZone.transform.position);

        // Get Destination
        if (atZone) {
            targetZone = Zones.Dequeue();
            atZone = false;
        }

        if (!atZone && !isTraveling) {
            nav.SetDestination (targetZone.transform.position);
            dist = Vector3.Distance(transform.position,
                targetZone.transform.position);
            isTraveling = true;
        }

        // set targetZone as destination
        if (isTraveling) {

            if (dist < 2 && isTraveling) {
                // Trigger wait
                // If wait is up : Trigger move
                atZone = true;
                isTraveling = false;
            }
        }
        
        // Return Destination to the end
        if (atZone) {
            Zones.Enqueue(targetZone);
            isTraveling = false;
        }
        
    }
}
