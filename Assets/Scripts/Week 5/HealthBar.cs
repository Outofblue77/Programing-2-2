using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float health = 10f;
    public Slider visualHealth;

    

    // Start is called before the first frame update
    void Start()
    {
        visualHealth.minValue = 0;
        visualHealth.maxValue = health;
        visualHealth.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            TakeDamage(1);
        }
                
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        visualHealth.value = health;
    }
}
