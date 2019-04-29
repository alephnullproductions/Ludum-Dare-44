using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New EventTask", menuName = "EventTask")]
public class EventTask : ScriptableObject {
    public string name;
    public string description;
//    public GameObject image;
    private List<IndividualTask> tasks;
}
