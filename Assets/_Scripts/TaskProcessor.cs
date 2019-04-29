using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskProcessor : MonoBehaviour
{
    private static TaskProcessor instance = null;

    public string[] targetNames;
    public Transform[] targets;

    public TaskSO[] possibleTasksSO;
    public Task[] possibleTasks;

    public static TaskProcessor getInstance()
    {
        return instance;
    }

    public Task[] GetTasks()
    {
        return possibleTasks;
    }

    private void Awake()
    {
        //Check if instance already exists
        if (instance == null)
            instance = this;

        else if (instance != this) { 
            Destroy(gameObject);
        }
        
        LoadTasks();
    }

    public void LoadTasks()
    {
        possibleTasks = new Task[possibleTasksSO.Length];
        for (int i = 0; i < possibleTasksSO.Length; i++)
        {
            possibleTasks[i] = new Task(possibleTasksSO[i]);
        }
    }
}

public class Task
{
    bool isComplete;
    float value;
    public string taskName;
    public string desc;
    public int timeLimit;
    public SubTask[] subTasks;
    public int currentSubtask;

    public Task(TaskSO theTask)
    {
        isComplete = false;
        value = theTask.value;
        taskName = theTask.taskName;
        desc = theTask.desc;
        timeLimit = theTask.timeLimit;
        subTasks = new SubTask[theTask.subTasks.Length];
        for(int i = 0; i < theTask.subTasks.Length; i++)
        {
            subTasks[i] = new SubTask(theTask.subTasks[i]);
        }
        currentSubtask = 0;
    }

    public void CompleteSubtask()
    {
        if(currentSubtask < subTasks.Length)
        {
            currentSubtask++;
        }
    }

    public SubTask GetCurrentSubTask()
    {
        return subTasks[currentSubtask];
    }
}

public class SubTask
{
    public Transform target;
    public GameObject mustBeDelivered;
    public float timeToComplete;
    public string desc;

    public SubTask(SubTaskSO theSubTask)
    {
        mustBeDelivered = theSubTask.mustBeDelivered;
        timeToComplete = theSubTask.timeToComplete;
        target = getGameObjectFromString(theSubTask.target);
        desc = theSubTask.description;
    }

    private Transform getGameObjectFromString(string target)
    {
        for(int i = 0; i < TaskProcessor.getInstance().targets.Length; i++)
        {
            if (TaskProcessor.getInstance().targetNames[i].Equals(target))
            {
                return TaskProcessor.getInstance().targets[i];
            }
        }

        return null;
    }

}