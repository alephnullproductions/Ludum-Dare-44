using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerStats", menuName = "PlayerStats")]
public class PlayerStats : ScriptableObject {
    
    public int hp;
    public int fatigue;
    public int money;

    public List<ScriptableObject> tasksRemaining;
    public bool areAllTasksDone;

    
}
