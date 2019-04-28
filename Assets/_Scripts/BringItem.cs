using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        // add a stipulation in here like: expects coffee
        if (other.transform.tag == "Coffee") {
            //Trigger Event
            Debug.Log("Coffee Delivered");
            Destroy(other.gameObject);
        }
        
        if (other.transform.tag == "Paper") {
            //Trigger Event
            Debug.Log("Paper Delivered");
            Destroy(other.gameObject);
        }
    }
}
