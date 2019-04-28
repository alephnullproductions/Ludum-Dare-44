using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelingManager : MonoBehaviour
{
    [SerializeField]
    GameObject celing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        celing.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
