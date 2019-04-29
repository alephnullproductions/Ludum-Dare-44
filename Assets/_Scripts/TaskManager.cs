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

    public void AddTasksFromSituation(SituationSO situation)
    {
        Debug.Log("Adding tasks from " + situation.SituationName);
        Task[] newTasks = taskProcessor.GetTasksFromSitatuionSO(situation);
        Debug.Log("Total Tasks " + newTasks.Length);
        tasks.AddRange(taskProcessor.GetTasksFromSitatuionSO(situation));
        UpdateUI();
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
        int f = 0;
        for (int i = 0; i < tasks.Count; i++)
        {
            if(tasks[i] != null && tasks[i].GetCurrentSubTask() != null)
            {
                taskLables[f].text = tasks[i].GetCurrentSubTask().desc;
                f++;
            }
        }
        while(f < tasks.Count && f < taskLables.Length)
        {
            taskLables[f].text = "";
            f++;
        }
    }


    public Task[] GetTasks()
    {
        return tasks.ToArray();
    }

    public bool CompleteSubTask(SubTask sub)
    {

        foreach(Task t in tasks)
        {
            if(t.GetCurrentSubTask() == sub)
            {

                t.CompleteSubtask();
                UpdateUI();
                return true;
            }
        }

        return false;
    }

    /*public Task GetTaskForSubtask(SubTask subtask)
    {
        foreach (Task t in tasks)
        {

        }
        return null;
    }*/

    public SubTask GetSubTaskFromTarget(GameObject gameobjectToTest)
    {
        Debug.Log("Testing " + gameobjectToTest);
        if(gameobjectToTest == null)
        {
            return null;
        }
        foreach(Task t in tasks)
        {
            Debug.Log("Against " + t.taskName); 
            if (gameobjectToTest != null && t.GetCurrentSubTask() != null && t.GetCurrentSubTask().target.Equals(gameobjectToTest.transform))
            {
                return t.GetCurrentSubTask();
            }
        }
        return null;
    }
}


