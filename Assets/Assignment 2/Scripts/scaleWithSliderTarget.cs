using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class scaleWithSliderTarget : MonoBehaviour
{
    public UnityEngine.UI.Slider scaleTarget;
    public GameObject target;

    float scaleValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scaleValue = scaleTarget.value;
        Vector3 size = new Vector3(scaleValue, scaleValue, scaleValue);           
        target.transform.localScale = size;
        //Update scale slider
        
    }
}
