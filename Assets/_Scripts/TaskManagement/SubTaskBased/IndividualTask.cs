using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New IndividualTask", menuName = "IndividualTask")]
public class IndividualTask : ScriptableObject {
    public List<SubTask> subTasks;
    public string title;
    public string description;
    public int reward;    // reward for completing
    public int penalty;    // penalty for not completing
    
}
