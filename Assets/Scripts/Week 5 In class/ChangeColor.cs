using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //public Color newColor;
    SpriteRenderer newColour;
    
    // Start is called before the first frame update
    void Start()
    {      
        
    }

    // Update is called oncse per frame
    void Update()
    {
        //SpriteRenderer shapeColor = GetComponent<SpriteRenderer>();
        //shapeColor.color = newColor;

        

    }
    
    public void changeColor(float a)
    {
        newColour.color = Random.ColorHSV();
    }

}
