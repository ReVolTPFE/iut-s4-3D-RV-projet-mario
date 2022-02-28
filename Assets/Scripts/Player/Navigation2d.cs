using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation2d : MonoBehaviour
{
    public GameObject Player;
    public float acceleration = 0.005f;
    public float maxSpeed = 0.03f;
    public float memoryAcceleration = 0;

    // Start is called before the first frame update
    void Start()
    {
        memoryAcceleration = acceleration;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            if ((acceleration * 1.01) < maxSpeed)
            {
                acceleration *= 1.01f;
            }
        }
        else
        {
            acceleration = memoryAcceleration;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.transform.position += transform.forward * acceleration;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.transform.position -= transform.forward * acceleration;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.transform.Rotate(new Vector3(0, 1, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.transform.Rotate(new Vector3(0, -1, 0));
        }
    }
}
