using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public Timer newTimer;
    private Vector3 mousePosition;
    private Ray rayOfLight;


    void Start()
    {
        mousePosition = Input.mousePosition;
        rayOfLight = new Ray(mousePosition, Vector3.up);
        Debug.DrawLine(rayOfLight.origin, Vector3.up*3,Color.red);

    }
    void Update()
    {
        newTimer.runTimer();
        
        mousePosition = Input.mousePosition;
        rayOfLight = new Ray(mousePosition, Vector3.up);
        Debug.DrawLine(rayOfLight.origin, rayOfLight.direction * 3,Color.red);
    }
}
