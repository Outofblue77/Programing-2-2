using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowSpawns : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {   
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Adjust mouse to match with current screen size
            Instantiate(prefab, mouse, Quaternion.identity);
            //Spawn a prefab of the object upon clicking with no rotation
        }
       
    }
}
