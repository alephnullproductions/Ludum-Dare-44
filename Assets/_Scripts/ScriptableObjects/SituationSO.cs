using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Situation", menuName = "Situation")]
public class SituationSO : ScriptableObject
{
    public string SituationName;
    public string SituationDescription;
    public TaskSO[] newTasks;
}
