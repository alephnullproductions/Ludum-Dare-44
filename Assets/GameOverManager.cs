using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public HealthStatusBarScript health;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health.health);
        if (health.health <= 0)
        {
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
    }
}
