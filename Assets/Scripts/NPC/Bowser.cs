using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowser : MonoBehaviour
{
    // for bowser animation
    public GameObject bowser;

    private bool bowserAnimated = false;

    public Camera bowserCamera;
    public Camera playerCamera;

    private int timestamp = 0;
    private bool hasCollide = false;
    private int bowserTransition = 650;
    public GameObject bowserText;

    public GameObject gombas;

    void Start()
    {
        bowserCamera.gameObject.SetActive(false);
        playerCamera.gameObject.SetActive(true);
        bowserText.gameObject.SetActive(false);
        gombas.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 9)
        {
            if (bowserAnimated == false)
            {
                bowserAnimated = true;
                bowser.GetComponent<Animator>().SetBool("introAnimation", true);

                bowserCamera.gameObject.SetActive(true);
                playerCamera.gameObject.SetActive(false);

                hasCollide = true;
            }
        }
    }

    void FixedUpdate()
    {
        if (hasCollide == true)
        {
            timestamp++;
        }

        if (hasCollide == true && timestamp < bowserTransition)
        {
            bowserCamera.gameObject.SetActive(true);
            playerCamera.gameObject.SetActive(false);
        }
        else
        {
            bowserCamera.gameObject.SetActive(false);
            playerCamera.gameObject.SetActive(true);
        }
        
        if (hasCollide == true && timestamp >= bowserTransition)
        {
            bowserText.gameObject.SetActive(true);
            gombas.gameObject.SetActive(true);
        }
    }
}