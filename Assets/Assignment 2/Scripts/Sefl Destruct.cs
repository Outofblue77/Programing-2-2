using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeflDestruct : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        //Destroy the summoned prefab (arrow) 32 seconds after spawning 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
