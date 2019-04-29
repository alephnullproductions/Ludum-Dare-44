using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Destinations", menuName = "Destinations")]
public class Destinations : ScriptableObject {
    public List<GameObject> places;
    public List<Vector3> Vector3s;
}
