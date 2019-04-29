using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SituationManager : MonoBehaviour
{
    [SerializeField]
    float timeInLevel = 0f;
    [SerializeField]
    float[] times;
    [SerializeField]
    SituationSO[] situations;
    bool[] hasOccured;
    
    [SerializeField]
    Canvas situationCanvas;
    [SerializeField]
    TextMeshProUGUI situationTitleText;
    [SerializeField]
    TextMeshProUGUI situationDesc;
    [SerializeField]
    TaskManager taskManager;

    private void Awake()
    {
        hasOccured = new bool[times.Length];
        for(int i = 0; i < times.Length; i++)
        {
            hasOccured[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!situationCanvas.isActiveAndEnabled) timeInLevel += Time.deltaTime;
        for (int i = 0; i < times.Length; i++){        
            if (!hasOccured[i] && timeInLevel > times[i])
            {
                PerformSituation(situations[i]);
                hasOccured[i] = true;
            }
        }
    }

    void PerformSituation(SituationSO situation)
    {
        situationCanvas.gameObject.SetActive(true);
        situationTitleText.text = situation.SituationName;
        situationDesc.text = situation.SituationDescription;
        taskManager.AddTasksFromSituation(situation);
    }
}
