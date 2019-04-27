using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskGenerationScript : MonoBehaviour
{
    public GameObject Task1Text;
    public GameObject Task2Text;
    public GameObject Task3Text;
    public GameObject Task4Text;
    public GameObject Task5Text;
    public GameObject Task6Text;
    public GameObject Task7Text;
    public GameObject Task8Text;
    public GameObject Task9Text;
    public GameObject Task10Text;
    public GameObject Task11Text;
    public GameObject Task12Text;
    public GameObject TaskCompletedImage;
    public Button TaskCompleteButton;
    public bool TaskCompleted;
    public int WichTask;
    public int ShowTask;
    public int WichTaskBefore;
    public int WichTaskBefore2;


    void Start()
    {
        WichTask = Random.Range(0, 12);
        ShowTask = WichTask;
    }


    void Update()
    {
        if (WichTask == WichTaskBefore || WichTask == WichTaskBefore2 && TaskCompleted == false)
        {
            WichTask = Random.Range(0, 12);
        }
        if (WichTask != WichTaskBefore && WichTask != WichTaskBefore2 && TaskCompleted == false)
        {
            ShowTask = WichTask;
        }

        if (ShowTask == 1)
        {
            Task1Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 2)
        {
            Task2Text.SetActive(true);
            Task1Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 3)
        {
            Task3Text.SetActive(true);
            Task2Text.SetActive(false);
            Task1Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 4)
        {
            Task4Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task1Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 5)
        {
            Task5Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task1Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 6)
        {
            Task6Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task1Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 7)
        {
            Task7Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task1Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 8)
        {
            Task8Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task1Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 9)
        {
            Task9Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task1Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 10)
        {
            Task10Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task1Text.SetActive(false);
            Task11Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 11)
        {
            Task11Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task1Text.SetActive(false);
            Task12Text.SetActive(false);
        }
        if (ShowTask == 12)
        {
            Task12Text.SetActive(true);
            Task2Text.SetActive(false);
            Task3Text.SetActive(false);
            Task4Text.SetActive(false);
            Task5Text.SetActive(false);
            Task6Text.SetActive(false);
            Task7Text.SetActive(false);
            Task8Text.SetActive(false);
            Task9Text.SetActive(false);
            Task10Text.SetActive(false);
            Task11Text.SetActive(false);
            Task1Text.SetActive(false);
        }

        if (!TaskCompleted)
        {
            TaskCompletedImage.SetActive(false);
            TaskCompleteButton.interactable = true;
        }
        if (TaskCompleted)
        {
            StartCoroutine(TaskCompletedAction());
        }
    }

    public void TaskComplete()
    {
        TaskCompleted = true;
        WichTaskBefore2 = WichTaskBefore;
        WichTaskBefore = WichTask;
    }

    IEnumerator TaskCompletedAction()
    {
        TaskCompleteButton.interactable = false;
        TaskCompletedImage.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        WichTask = Random.Range(0, 12);
        if(WichTask == WichTaskBefore || WichTask == WichTaskBefore2)
        {
            WichTask = Random.Range(0, 12);
        }
        TaskCompleted = false;
    }
}
