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
    public GameObject PlayerPosition;
    public GameObject EndTaskPosition;
    public GameObject EndTask1;
    public GameObject EndTask2;
    public GameObject EndTask3;
    public GameObject EndTask4;
    public GameObject EndTask5;
    public GameObject EndTask6;
    public GameObject EndTask7;
    public GameObject EndTask8;
    public GameObject EndTask9;
    public GameObject EndTask10;
    public GameObject EndTask11;
    public GameObject EndTask12;
    public Button TaskCompleteButton;
    public bool TaskCompleted;
    public int WichTask;
    public int ShowTask;
    public int WichTaskBefore;
    public int WichTaskBefore2;
    public float RoomHeight;


    void Start()
    {
        WichTask = Random.Range(0, 12);
        ShowTask = WichTask;
    }


    void Update()
    {
        if (PlayerPosition.transform.position.x < EndTaskPosition.transform.position.x + RoomHeight && PlayerPosition.transform.position.x > EndTaskPosition.transform.position.x - RoomHeight && PlayerPosition.transform.position.z < EndTaskPosition.transform.position.z + RoomHeight && PlayerPosition.transform.position.z > EndTaskPosition.transform.position.z - RoomHeight)
        {
            TaskCompleted = true;
            EndTaskPosition.transform.Translate(99999, 99999, 99999);
        }
        if (WichTask == WichTaskBefore || WichTask == WichTaskBefore2 && TaskCompleted == false)
        {
            WichTask = Random.Range(0, 12);
        }
        if (WichTask != WichTaskBefore && WichTask != WichTaskBefore2 && TaskCompleted == false)
        {
            ShowTask = WichTask;
        }

        if (ShowTask == 1 && !TaskCompleted)
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
            EndTaskPosition = EndTask1;
        }
        if (ShowTask == 2 && !TaskCompleted)
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
            EndTaskPosition = EndTask2;
        }
        if (ShowTask == 3 && !TaskCompleted)
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
            EndTaskPosition = EndTask3;
        }
        if (ShowTask == 4 && !TaskCompleted)
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
            EndTaskPosition = EndTask4;
        }
        if (ShowTask == 5 && !TaskCompleted)
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
            EndTaskPosition = EndTask5;
        }
        if (ShowTask == 6 && !TaskCompleted)
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
            EndTaskPosition = EndTask6;
        }
        if (ShowTask == 7 && !TaskCompleted)
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
            EndTaskPosition = EndTask7;
        }
        if (ShowTask == 8 && !TaskCompleted)
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
            EndTaskPosition = EndTask8;
        }
        if (ShowTask == 9 && !TaskCompleted)
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
            EndTaskPosition = EndTask9;
        }
        if (ShowTask == 10 && !TaskCompleted)
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
            EndTaskPosition = EndTask10;
        }
        if (ShowTask == 11 && !TaskCompleted)
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
            EndTaskPosition = EndTask11;
        }
        if (ShowTask == 12 && !TaskCompleted)
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
            EndTaskPosition = EndTask12;
        }

        if (!TaskCompleted)
        {
            TaskCompletedImage.SetActive(false);
            TaskCompleteButton.interactable = true;
        }
        if (TaskCompleted)
        {
            WichTaskBefore2 = WichTaskBefore;
            WichTaskBefore = WichTask;
            StartCoroutine(TaskCompletedAction());
        }
    }

    public void TaskComplete()
    {
        TaskCompleted = true;
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
