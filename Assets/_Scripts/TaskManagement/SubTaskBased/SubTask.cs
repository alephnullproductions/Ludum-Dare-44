﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SubTask", menuName = "SubTask")]
public class SubTask : ScriptableObject {
    public string title;
    public string description;
    public float timeLimit;
    
}
