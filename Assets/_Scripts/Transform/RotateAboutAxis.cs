using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAboutAxis : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, 5*Time.deltaTime);   
    }
}
