using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanvasCloser : MonoBehaviour
{
    public void ClosePanel()
    {
        Time.timeScale = 1f;
        EventSystem.current.SetSelectedGameObject(null);
        this.gameObject.SetActive(false);
    }
}
