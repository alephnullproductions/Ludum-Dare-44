using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractItem : MonoBehaviour {
    public float rayRange = 100f;
    public float interactRange = 1.5f;


//    public Interactable held;
    public bool isItemHeld = false;
    public GameObject heldLocation;
    public GameObject heldObject;

    
    private int pickupLayerMask;
    private int interactLayerMask;
    
    
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

//        if (Input.GetButtonDown())) {}
        if (Physics.Raycast(camRay, out hit, rayRange)) {
            
            // Q - Toggle Carry
            if (Input.GetKey(KeyCode.Q)) {
                //checking raycast

                // for convenience
                var hitObject = hit.collider.gameObject;
                if (hitObject.layer == pickupLayerMask) {

                    heldObject = hitObject;
                    heldObject.transform.position = heldLocation.transform.position;
                    heldObject.transform.SetParent(heldLocation.transform);

                    
                    // TODO
                    // set LayerMask to Ignore
//                        hitObject.layer 
                    hitObject.layer = LayerMask.NameToLayer("Ignore Raycast");     // it works
                    hitObject.transform.localScale.Set(0.5f,0.5f,0.5f);
                    // turn off collision
                    // shrink object
                    
                    isItemHeld = true;
                    Debug.Log(hit.transform.name);
                }

//                held = hit.transform.GetComponent<Interactable>();
//                Debug.Log(hit.transform.GetComponent<Interactable>().name);
//
//                held.GetComponent<GameObject>().transform.SetParent(heldLocation);
            }
            
            // E - Interact
            if (Input.GetKey(KeyCode.E)) {
                var hitObject = hit.collider.gameObject;


                if (isItemHeld && hitObject.layer == interactLayerMask) {
                    // Determine if both objects interact
                        // If yes, destroy object, perform activity
                        
                        Destroy(heldObject);
                        isItemHeld = false;
                        Debug.Log("Perform Action between:");

                }
                else if (hitObject.layer == interactLayerMask) {
                    
                }
                
                
            }




        }
    }
}
