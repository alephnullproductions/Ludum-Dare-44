using System.Collections;
using System.Collections.Generic;
using GameEvents;
using UnityEngine;

public class CountdownObject : MonoBehaviour {

    // 600 = 10 minutes
    // 60*8 = 480 = 8 minutes
    // 60 - 1 minute
    public int secondsCountdown;
    private float timeLeft;
    public GameEvent gameEvents;

    void Awake() {
        timeLeft = secondsCountdown;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        timeLeft -= Time.deltaTime;
        Debug.Log("Countdown: "+timeLeft);
        if (timeLeft < 0) {
            gameEvents.Raise();
            Debug.Log("Time Up");
        }
        
    }
}
