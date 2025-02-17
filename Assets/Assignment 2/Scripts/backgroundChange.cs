using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;



public class backgroundChange : MonoBehaviour
{
    public int currentScene = 1;
    public GameObject Castle;
    public GameObject Outside;


    void Start()
    {
        Castle.SetActive(false);
        Outside.SetActive(false);
    }

    void Update()
    {
        if (currentScene > 0)
        {
            Outside.SetActive(true);
            Castle.SetActive(false);
        }
        else if (currentScene < 0)
        {
            Castle.SetActive(true);
            Outside.SetActive(false);
        }
    }

    public void change(float a)
    {
        currentScene *= -1;
    }
}




