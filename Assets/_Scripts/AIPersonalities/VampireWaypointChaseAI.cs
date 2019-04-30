using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Ywz;


public class VampireWaypointChaseAI : MonoBehaviour {

    public enum VampState {
        Patrol, Chase, Wander
    }
    
    public bool isVampire;
    
    public GameObject targetZone;

    [SerializeField]
    private Vector3 targetLocation;
    
    // shortcut for now
    public GameObject player;
    // if player nearby, pause and seek out player for a period of time.
    public float dist2Player = 100;
    public float playerChaseCooldown = 2;

    private bool atPlayer;
    

    public List<GameObject> zlist = new List<GameObject>();
    private int index = 0;

    [SerializeField] public Queue<GameObject> Zones = new Queue<GameObject>();
    // Zones need a container object with wait duration...

    [SerializeField]
    private float dist = 100;
    private NavMeshAgent nav;
    
    private bool atZone = false;
    private bool isTraveling = false;

    [SerializeField] private VampState state = VampState.Patrol;



    /// <summary>
    /// Wait Scaffolding
    /// </summary>
    [SerializeField]
    private float wait = 0;

    [SerializeField] private int patrolTime = 21;
    [SerializeField] private int chaseTime = 10;

    [SerializeField] private float patrolDistCheck = 2.1f;
    
    private float travel = 0;
    
    private float ReduceTick() {
        wait = wait - Time.deltaTime;
        return wait;
    }

    private void ResetTick(float waitAmount) {
        wait = waitAmount;
    }
    
    private void Awake() {
        Zones = new Queue<GameObject>(zlist);
        nav = GetComponent<NavMeshAgent>();

        index = (index + 1) % zlist.Count;
        targetZone = zlist[index];
        nav.SetDestination (targetZone.transform.position);
    }


    // Update is called once per frame
    void Update() {

        // Reset
        var tick = ReduceTick();
        if (tick < 1) {
            Debug.Log("Tick under 1 reseting");
            ResetTick(patrolTime + chaseTime);
            return;
        } else if (tick < chaseTime) { // Chase Mode, aka Feed Mode
            Debug.Log("Tick under chase chasing");
            state = VampState.Chase;
            nav.SetDestination (player.transform.position);
            dist2Player = Vector3.Distance(transform.position,
                player.transform.position);

            if (dist2Player <= patrolDistCheck) {
                nav.SetDestination (player.transform.position);
                // Perform animation
                // 
                atPlayer = true;
                Debug.Log("Player Attacked");
                ResetTick(patrolTime + chaseTime);
            }
            else {
                atPlayer = false;
            }
            // Start Cooldown
        }
        // Patrol
        else {
            Debug.Log("Tick above chase time, patroling " + targetZone.name);
            // if tick > waitGoal
            targetLocation = targetZone.transform.position;
            state = VampState.Patrol;
            dist = Vector3.Distance(transform.position,
                targetZone.transform.position);
            nav.SetDestination (targetZone.transform.position);
            if (Vector3.Distance(transform.position, targetZone.transform.position) > patrolDistCheck) {
                nav.SetDestination (targetZone.transform.position);
//                Debug.Log("> 0.5f");
                return;
            }
            // Get Next
            else {
//                Debug.Log("< 0.5f");
                index = (index + 1) % zlist.Count;
                targetZone = zlist[index];
            }
        }
        
    }
}
