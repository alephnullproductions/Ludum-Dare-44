using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using Random = UnityEngine.Random;

// On guard - Will Follow Player on Sight
// Random Walk, sort of
public class RandomWalk : MonoBehaviour
{
    private int playerLayerMask;
    private string tagTargetValue = "Player";    
    private int rayRange = 20;

    private int angleInt = 0;
    private Quaternion angle;

    private float wait = 0;

    [SerializeField]
    private int waitCoefficient = 1000;
    
    
    private float ReduceTick() {
        wait = wait - 1;
        return wait;
    }

    private void ResetTick(float waitAmount) {
        wait = waitAmount;
    }

    private NavMeshAgent nav;

    private void Awake() {
        playerLayerMask = LayerMask.NameToLayer("Player");
        nav = transform.GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (ReduceTick() > 1)
            return;
        Debug.Log(wait);
        
        Debug.DrawRay(transform.position, 
            transform.forward * rayRange, Color.red);    // RayCast Visualization
        
        RaycastHit hit;
        Ray forwardRay = new Ray(transform.position, transform.forward);    // Actual RayCast
        
        if (Physics.Raycast(forwardRay, out hit, rayRange)) {

            var hitObject = hit.collider.gameObject;
            if (hitObject.layer == playerLayerMask) {
                Debug.Log(hit.transform.name);

                this.transform.LookAt(hitObject.transform);
                nav.SetDestination(hitObject.transform.position);

                ResetTick(waitCoefficient);    // 60 frames per second assumed
            }
            else {
                // Wander
                Vector3 randPos = new Vector3(Random.Range(-40f,30f), 0, Random.Range(-68.6f, 12.7f));
                nav.SetDestination(randPos);
                
                Debug.Log("Else");
                ResetTick(waitCoefficient);    // 60 frames per second assumed
            }
        }
        else {
            // Wander
            Vector3 randPos = new Vector3(Random.Range(-40f,30f), 0,Random.Range(-68.6f, 12.7f));
            nav.SetDestination(randPos);
            
            Debug.Log("No Ray Detection");
            ResetTick(waitCoefficient);    // 60 frames per second assumed

        }
        
        // otherwise move forward somehow
        // unless hits wall
         // in which case wander until no longer against wall

    }
}
