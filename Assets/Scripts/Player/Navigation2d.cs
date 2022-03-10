using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation2d : MonoBehaviour
{
    
    public GameObject Player;
    public Camera cameraFocusPlayer;
    public float acceleration = 0.001f;
    public float maxSpeed = 0.03f;
    public float memoryAcceleration = 0;

    public bool isGrounded;
    public Vector3 jump;
    public float jumpForce = 3.0f;
    Rigidbody rb;

    private Vector3 coordY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        memoryAcceleration = acceleration;
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        coordY = Player.transform.position;
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
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

        if (!Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.D))
        {
            Player.GetComponent<Animator>().SetBool("move", false);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Player.GetComponent<Animator>().SetBool("move", true);
            Player.transform.position += transform.forward * acceleration;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Player.GetComponent<Animator>().SetBool("move", true);

            Player.transform.position -= transform.forward * acceleration;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.GetComponent<Animator>().SetBool("move", true);

            Player.transform.Translate(Vector3.right * acceleration);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Player.GetComponent<Animator>().SetBool("move", true);

            Player.transform.Translate(Vector3.left * acceleration);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            if(Player.transform.position != coordY)
            {
                isGrounded = false;
                Player.GetComponent<Animator>().SetTrigger("jump");
                rb.velocity = Vector3.up * jumpForce;
            }

            coordY = Player.transform.position;

        }
    }

    void OnCollisionEnter(Collision c) {
        acceleration = 0.01f;
    }
}
