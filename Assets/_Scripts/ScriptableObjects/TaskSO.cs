using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Task", menuName = "Task")]
public class TaskSO : ScriptableObject
{
    public string taskName;
    public string desc;
    public int timeLimit;
    public float value;
    public SubTaskSO[] subTasks;
}
