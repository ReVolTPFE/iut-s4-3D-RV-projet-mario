using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation2d : MonoBehaviour
{
    public GameObject Camera;
    public float acceleration;
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            if ((acceleration * 1.01) < maxSpeed)
            {
                acceleration *= 1.01f;
            }
        }
        else
        {
            acceleration = 0.1f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Camera.transform.position += new Vector3(0, acceleration, 0); ;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Camera.transform.position += new Vector3(0, -acceleration, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.transform.position += new Vector3(acceleration, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Camera.transform.position += new Vector3(-acceleration, 0, 0);
        }
    }
}
