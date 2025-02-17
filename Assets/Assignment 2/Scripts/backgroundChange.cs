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
    public GameObject Ground;


    void Start()
    {
        Castle.SetActive(false);
        Outside.SetActive(false);
        Ground.SetActive(false);
    }

    void Update()
    {
        if (currentScene > 0)
        {
            Outside.SetActive(true);
            Castle.SetActive(false);
            Ground.SetActive(false);
        }
        else if (currentScene < 0)
        {
            Castle.SetActive(true);
            Outside.SetActive(false);
            Ground.SetActive(true);
        }
    }

    public void change(float a)
    {
        currentScene *= -1;
    }
}




