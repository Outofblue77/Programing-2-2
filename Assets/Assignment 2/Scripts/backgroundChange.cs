using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

// Script to change background

public class backgroundChange : MonoBehaviour
{
    public int currentScene = 1;
    public GameObject Castle;
    public GameObject Outside;
    public GameObject Ground;


    void Start()
    {
        Castle.SetActive(false);
        Outside.SetActive(false);
        Ground.SetActive(false);
        //Preset ensure no double backgrounds are shown
    }

    void Update()
    {
        if (currentScene > 0)
        {
            Outside.SetActive(true);
            Castle.SetActive(false);
            Ground.SetActive(false);
            //What background to show b activating it when the variable is less than 0
        }
        else if (currentScene < 0)
        {
            Castle.SetActive(true);
            Outside.SetActive(false);
            Ground.SetActive(true);
            // Changes of what is active to change the background
        }
    }

    public void change(float a)
    {
        currentScene *= -1;
        //When Button is pressed change the value of a scene variable
    }
}




