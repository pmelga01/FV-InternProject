using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketGame : MonoBehaviour
{
    private GameObject needle;
    private GameObject meter;
    // Start is called before the first frame update
    
    void Awake()
    {
        needle = GameObject.Find("needle");
        meter = GameObject.Find("meter");
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        //needle.Transform.rottat
    }
}
