using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassPoint : MonoBehaviour {

    public List<GameObject> gameTasks;
    public GameObject currentTask;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(currentTask.transform);
    }
}
