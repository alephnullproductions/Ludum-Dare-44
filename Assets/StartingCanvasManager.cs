using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartingCanvasManager : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.MouseLook mouseLook = new UnityStandardAssets.Characters.FirstPerson.MouseLook();

    [SerializeField] Canvas genericCanvas;

    // Start is called before the first frame update
    void Start()
    {
        genericCanvas.gameObject.SetActive(false);
        mouseLook.Init(transform, Camera.main.transform);
        mouseLook.SetCursorLock(false);

        Time.timeScale = 0f;
    }

    public void CloseStartPanel()
    {
        Time.timeScale = 1f;
        mouseLook.SetCursorLock(true);
        gameObject.SetActive(false);
        genericCanvas.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
