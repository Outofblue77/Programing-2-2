using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class timeMovement : MonoBehaviour
{
    public GameObject Sun;
    public GameObject Moon;
    //Calling to get objects in unity
    public Slider position;
    
    void Update()
    {
        Vector3 sunpos = Sun.transform.position;
        Vector3 moonpos = Moon.transform.position;
        //Creating vectors for both sun and moon objects
        sunpos.x = position.value - 5;
        moonpos.x = position.value - 19;
        //Creationg intial positions and distanct between objects
        Sun.transform.position = sunpos;
        Moon.transform.position = moonpos;
        //Update Objects p[ositions
    }

    
    
}
