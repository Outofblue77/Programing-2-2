using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class ButtonTest : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector3 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        if (screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        transform.position = pos;

    }

    public void Go(float s)
    {
        speed = s;
    }

    public void Stop()
    {
        speed = 0;
    }
}
