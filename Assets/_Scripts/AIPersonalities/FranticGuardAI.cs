using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using Random = UnityEngine.Random;

// On guard - Will Follow Player on Sight
// Random Walk, sort of
public class FranticGuardAI : MonoBehaviour
{
    private int playerLayerMask;
    private string tagTargetValue = "Player";    
    private int rayRange = 20;

    private int angleInt = 0;
    private Quaternion angle;

    private float wait = 0;
    
    
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

                ResetTick(5 * Time.deltaTime);    // 60 frames per second assumed
            }
            else {
                // Rotate Right
    //            transform.Rotate(new Vector3(0,90,0));
//    transform.RotateAround(new Vector3(0,0,0),new Vector3(0,90,0),15);
//                angle = Quaternion.Euler(new Vector3(0, 15, 0)) * angle;
                angleInt = angleInt + 2;
                transform.Rotate(new Vector3(0,angleInt,0), angleInt);
                
                // Search for Player
                
                
//                nav.Move(new Vector3(0,0,0));
//                transform.rotation = Quaternion.EulerAngles(0, 1 * angleInt, 0);
                Debug.Log("Else");
    
            }
        }
        else {
            
            // Wander
            Vector3 randPos = new Vector3(Random.Range(-65f,28f), Random.Range(-68.6f, 12.7f));
            nav.SetDestination(randPos);
            
//            angleInt = angleInt + 2;
//            transform.Rotate(new Vector3(0,angleInt,0), angleInt);
//            
            Debug.Log("No Ray Detection");

        }
        
        // otherwise move forward somehow
        // unless hits wall
         // in which case wander until no longer against wall

    }
}
