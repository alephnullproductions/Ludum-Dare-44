﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HealthStatusBarScript : MonoBehaviour {

    public float health = 100;
    public int healthSegments = 10;
    
    private float hpSegmentSize;
    private float startingHealthWidth;

//    public AudioClip takedamageSound;
    
    
    public Texture backgroundTexture;
    public Texture foregroundTexture;
    public Texture frameTexture;

    public float healthWidth = 199;
    public int healthHeight = 30;

    public int healthMarginLeft = 41;
    public int healthMarginTop = 38;

    public int frameWidth = 10;
    public int frameHeight = 10;

    public int frameMarginLeft = 10;
    public int frameMarginTop = 10;

    private void OnGUI() {
        GUI.DrawTexture( 
            new Rect(frameMarginLeft,
                frameMarginTop, 
                frameMarginLeft + frameWidth, 
                frameMarginTop + frameHeight), 
            backgroundTexture, 
            ScaleMode.ScaleToFit, true, 0 );
    
        GUI.DrawTexture(
            new Rect(healthMarginLeft,
                healthMarginTop,
                healthWidth + healthMarginLeft, 
                healthHeight), 
            foregroundTexture, ScaleMode.ScaleAndCrop, true, 0 );
    
        GUI.DrawTexture(
            new Rect(frameMarginLeft,
                frameMarginTop, 
                frameMarginLeft + frameWidth,
                frameMarginTop + frameHeight), 
            frameTexture, ScaleMode.ScaleToFit, true, 0 );
    }


    void ReduceHp() {
        health -= 2 * (health/healthSegments * Time.deltaTime);
        healthWidth -= 2 * (startingHealthWidth / healthSegments * Time.deltaTime);
        
        
    }
    
    void MajorReduceHp() {
        health -= 5 * (health/healthSegments * Time.deltaTime);
        healthWidth -= 5 * (startingHealthWidth / healthSegments * Time.deltaTime);
        
    }
    

    private void OnCollisionStay(Collision other) {
        if (other.transform.CompareTag("Vampire")) {
            MajorReduceHp();    // Reduce Health
            // Trigger Sound Effect taking Damage
            Debug.Log("Reduce Hp");
        }
//        print(other.transform.tag);
    }


    private void OnTriggerStay(Collider other) {
        if (other.transform.CompareTag("Vampire")) {
            ReduceHp();    // Reduce Health
            // Trigger Sound Effect taking Damage
            Debug.Log("Reduce Hp");
        }
    }

//    private void OnCollisionExit(Collision other) {
//        if (other.transform.CompareTag("Vampire")) {
//            
//        }
//    }

    void TriggerGameOverScreen() {
        
    }

    void Awake() {
        hpSegmentSize = healthWidth / healthSegments;
        startingHealthWidth = healthWidth;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
