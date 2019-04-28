using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level")]
public class Level : ScriptableObject {
    public string text;
    public string description;
    
    // Player Objectives
    // Work Tasks
    public List<GameObject> tasks;

    // Day Tasks
    public List<GameObject> obligations;
    
    // Actors
    public List<GameObject> vampires;   
    public List<GameObject> humans;
}
