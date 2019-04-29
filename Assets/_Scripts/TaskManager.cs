using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public List<Task> tasks = new List<Task>();
    public TextMeshProUGUI[] taskLables;
    private bool isLoaded = false;
    private TaskProcessor taskProcessor;

    public int numberOfStartingTasks = 1;

    private void Awake()
    {
        taskProcessor = GetComponent<TaskProcessor>();
    }

    private void Update()
    {
        if (!isLoaded)
        {
            if(numberOfStartingTasks > taskProcessor.GetTasks().Length)
            {
                numberOfStartingTasks = taskProcessor.GetTasks().Length;
            }

            Debug.Log(numberOfStartingTasks);

            for (int i = 0; i < numberOfStartingTasks; i++ ) {
                Task task;
                do
                {
                    task = taskProcessor.GetTasks()[Random.Range(0, taskProcessor.GetTasks().Length)];
                } while (isDuplicate(task));

                AddTask(task);
            }
            UpdateUI();
            isLoaded = true;
        }
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    private bool isDuplicate(Task task)
    {
        foreach(Task t in tasks) {
            if (t.desc.Equals(task.desc))
                return true;
        }
        return false;
    }

    public void UpdateUI()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            taskLables[i].text = tasks[i].GetCurrentSubTask().desc;
        }
    }


    public Task[] GetTasks()
    {
        return tasks.ToArray();
    }

    public bool IsThisATarget(GameObject gameobjectToTest)
    {

        
        foreach(Task t in tasks)
        {
            
            if (t.GetCurrentSubTask().target.Equals(gameobjectToTest.transform))
            {
                Debug.Log("Found " + t.GetCurrentSubTask().target.gameObject.name);
                return true;
            }
        }
        Debug.Log("Did not find " + gameobjectToTest.name);
        return false;
    }
}


