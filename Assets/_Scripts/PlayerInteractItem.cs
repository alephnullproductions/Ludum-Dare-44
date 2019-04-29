using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractItem : MonoBehaviour {
    public float rayRange = 100f;
    public float interactRange = 1.5f;


//    public Interactable held;
    public bool isItemHeld = false;
    public GameObject heldLocation;
    public GameObject heldObject;
 
    private int pickupLayerMask;
    private int interactLayerMask;

    [SerializeField]
    Canvas FtoPickupCanvas;
    [SerializeField]
    Canvas FtoInteractCanvas;
    [SerializeField]
    TaskManager taskManager;
    [SerializeField]
    Slider taskCompletionSlider;
    [SerializeField]
    Canvas situationCanvas;
    
    // Determine if we can see object with RayCast
    
    
    // Start is called before the first frame update
    void Start() {
        pickupLayerMask = LayerMask.NameToLayer("Pickup");
        interactLayerMask = LayerMask.NameToLayer("Interact");
    }

    // Update is called once per frame
    void Update() {
        
        RaycastHit hit;
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        FtoInteractCanvas.gameObject.SetActive(false);
        FtoPickupCanvas.gameObject.SetActive(false);

        SubTask currentSubtask = null;
        if(heldObject != null && (currentSubtask = taskManager.GetSubTaskFromTarget(heldObject)) != null)
        {

            taskManager.CompleteSubTask(currentSubtask);
        }

        //        if (Input.GetButtonDown())) {}
        if (!situationCanvas.isActiveAndEnabled && Physics.Raycast(camRay, out hit, rayRange)) {
            
            var hitObject = hit.collider.gameObject;

            if (hitObject.layer == pickupLayerMask)
            {
                FtoPickupCanvas.gameObject.SetActive(true);
            }
            if (hitObject != null)
            {
                currentSubtask = taskManager.GetSubTaskFromTarget(hitObject);
            }

            if(hitObject.layer == interactLayerMask && currentSubtask != null)
            {
                FtoInteractCanvas.gameObject.SetActive(true);
                taskCompletionSlider.value = currentSubtask.timeSpent == 0? currentSubtask.timeSpent : currentSubtask.timeSpent / currentSubtask.timeToComplete * 100;
            }
            // Q - Toggle Carry
            if (Input.GetKey(KeyCode.F)) {
                //checking raycast

                // for convenience
                if (hitObject.layer == interactLayerMask)
                {
                    // Determine if both objects interact
                    // If yes, destroy object, perform activity

                    if (currentSubtask != null && (currentSubtask.timeToComplete > currentSubtask.timeSpent && (currentSubtask.timeSpent != 0 || Input.GetKeyDown(KeyCode.F))))
                    {
                        currentSubtask.timeSpent += Time.deltaTime;
                        
                    } else if(currentSubtask != null && currentSubtask.timeSpent >= currentSubtask.timeToComplete)
                    {
                        if (currentSubtask.isConsumed)
                        {
                            Destroy(heldObject);
                        }
                        taskManager.CompleteSubTask(currentSubtask);
                    }


                    //Destroy(heldObject);
                    //isItemHeld = false;
                    //Debug.Log("Perform Action between:");

                }
                else if (hitObject.layer == pickupLayerMask) {

                    heldObject = hitObject;
                    heldObject.transform.position = heldLocation.transform.position;
                    heldObject.transform.SetParent(heldLocation.transform);
                    heldObject.GetComponent<Rigidbody>().isKinematic = true;
                    
                    
                    // TODO
                    // set LayerMask to Ignore
//                        hitObject.layer 
                    hitObject.layer = LayerMask.NameToLayer("Ignore Raycast");     // it works
//                    hitObject.transform.localScale.Set(0.5f,0.5f,0.5f);

                    // turn off collision
                    // shrink object
                    
                    isItemHeld = true;

                }

//                held = hit.transform.GetComponent<Interactable>();
//                Debug.Log(hit.transform.GetComponent<Interactable>().name);
//
//                held.GetComponent<GameObject>().transform.SetParent(heldLocation);
            }
            
            // E - Interact
            if (Input.GetKey(KeyCode.F)) {
                
             
                
                
            }




        }
    }
}
