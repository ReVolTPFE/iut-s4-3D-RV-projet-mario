using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation2d : MonoBehaviour
{
    public GameObject Player;
    public Camera cameraFocusPlayer;
    public float acceleration = 0.005f;
    public float maxSpeed = 0.03f;
    public float memoryAcceleration = 0;
    public int jumpForce = 500;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    // Start is called before the first frame update
    void Start()
    {
        memoryAcceleration = acceleration;
    }

    // Update is called once per frame
    void Update()
    {
        float rotateX = 5 * Input.GetAxis("Mouse X");
        float rotateY = 5 * Input.GetAxis("Mouse Y");
        Player.transform.Rotate(0, rotateX, 0);

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

        if (Input.GetKey(KeyCode.Z))
        {
            Player.transform.position += transform.forward * acceleration;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Player.transform.position -= transform.forward * acceleration;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Translate(Vector3.right * acceleration);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Player.transform.Translate(Vector3.left * acceleration);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.transform.position += (Vector3.up * jumpForce * Time.deltaTime);
        }
    }
}
