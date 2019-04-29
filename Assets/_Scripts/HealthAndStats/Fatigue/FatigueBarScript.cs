using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatigueBarScript : MonoBehaviour {
    public Texture backgroundTexture;
    public Texture foregroundTexture;
    public Texture frameTexture;

    public int healthWidth = 199;
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
