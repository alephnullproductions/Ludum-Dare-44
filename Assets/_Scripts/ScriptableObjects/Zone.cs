using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Zone", menuName = "Zone")]
public class Zone : ScriptableObject
{
    // These are Waypoints
    public string title; // such as someone's Desk
    
    // Example:
    // Kitchen takes 10 seconds because people eat there
    public string purposeOfZone;

    public float humanActivityDuration;

    public GameObject relatedObject;
    public GameObject relatedPerson;
    
}
