using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New InteractiveItem", menuName = "InteractiveItem")]
public class InteractiveItem : ScriptableObject {
    
    public string title;
    public string tag_name;

    public bool isPocketable;
    public bool isInteractive;

    // Do I need this?
    public bool isTaskItem;

    public bool isRepairedOrOn;

    public GameObject taskDestinationObject;


}
