using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIObjectiveController : MonoBehaviour {

    public bool isVampire;
    
    public GameObject targetZone;
    
    // shortcut for now
    public GameObject player;
    // if player nearby, pause and seek out player for a period of time.
    public float dist2Player = 100;
    public float playerChaseCooldown = 2;

    private bool atPlayer;
    

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
        player = GameObject.FindGameObjectWithTag("Player");

        targetZone = Zones.Dequeue();
        atZone = false;
        dist = Vector3.Distance(transform.position,
            targetZone.transform.position);

        if (isVampire) {
            dist2Player = Vector3.Distance(transform.position,
                player.transform.position);        
        }
    }


    // Update is called once per frame
    void Update() {

        playerChaseCooldown -= Time.deltaTime;
        if (isVampire) {
            playerChaseCooldown -= Time.deltaTime;

            if (playerChaseCooldown <= 0) {
                atPlayer = false;
            }
            
//            Debug.Log(targetZone.name+" : "+dist2Player+" : "+playerChaseCooldown);
            dist2Player = Vector3.Distance(transform.position,
                player.transform.position);
            
            // 
            if (atPlayer) {
                playerChaseCooldown = 2;
//                nav.SetDestination (player.transform.position);
                dist2Player = Vector3.Distance(transform.position,
                    player.transform.position);
            }
            // player in range
            else if (dist2Player < 10 && playerChaseCooldown <= 0) {
                nav.SetDestination (player.transform.position);
                dist2Player = Vector3.Distance(transform.position,
                    player.transform.position);
    
                if (dist2Player <= 3) {
                    nav.SetDestination (player.transform.position);
                    // Perform animation
                    // 
                    atPlayer = true;
                }
                else {
                    atPlayer = false;
                }
                // Start Cooldown
            }
            else {
                dist = Vector3.Distance(transform.position,
                    targetZone.transform.position);
                nav.SetDestination (targetZone.transform.position);
            }
        }
        
        
        // reduce countdown
        if(!isVampire || playerChaseCooldown >= 1 || dist2Player > 10) {
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
}
