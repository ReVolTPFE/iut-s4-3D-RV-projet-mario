using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTransition : MonoBehaviour
{
    public Camera startCamera;
    public Camera playerCamera;

    public GameObject animatedMario;
    public GameObject playerMario;
    public GameObject castleFloor;

    private int timestamp = 0;
    private int firstTransition = 200;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera.gameObject.SetActive(false);
        startCamera.gameObject.SetActive(true);

        playerMario.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timestamp++;

        if (timestamp > firstTransition)
        {
            animatedMario.SetActive(false);
            playerMario.SetActive(true);
            playerCamera.gameObject.SetActive(true);
            startCamera.gameObject.SetActive(false);
        }
    }
}
