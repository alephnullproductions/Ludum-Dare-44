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
        UpdateUI();
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
                if(!tasks[i].isFailed())
                {
                    tasks[i].timeSinceRecieved += Time.deltaTime;
                    taskLables[f].color = Color.black;
                }
                else
                {
                    tasks[i].timeSinceRecieved = tasks[i].timeLimit;
                    taskLables[f].color = Color.red;
                }
                if (tasks[i].isFailed())
                {
                    taskLables[f].text = tasks[i].GetCurrentSubTask().desc + " FAILED";
                }
                else
                {
                    taskLables[f].text = tasks[i].GetCurrentSubTask().desc + " " + Mathf.Ceil(tasks[i].timeLimit - tasks[i].timeSinceRecieved);
                }
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
        if(gameobjectToTest == null)
        {
            return null;
        }
        foreach(Task t in tasks)
        {

            if (!t.isFailed() && gameobjectToTest != null && t.GetCurrentSubTask() != null && t.GetCurrentSubTask().target.Equals(gameobjectToTest.transform))
            {
                Debug.Log("Found " + t.taskName);
                return t.GetCurrentSubTask();
            }
        }
        return null;
    }
}


