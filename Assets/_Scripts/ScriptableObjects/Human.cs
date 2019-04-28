using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Human", menuName = "Human")]
public class Human : ScriptableObject {
    
    public string title;              // should this randomize name from pool?
    public string role; // What their job is at the office
    public GameObject person;        // 3DModel Representation

    //Statistics
    // move speed without modifiers
    public float baseMoveSpeed;
    

    public float stumbleProbability;  // When stuble timer is up while human moves, determine if stumbles

    public int hp; // health points
    public int hunger;
    public int fatigue;
    public int money;
}

