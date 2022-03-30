using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarCatchUndertale : MonoBehaviour
{
    public int nbStar = 0;
    public GameObject pickupEffect;
    public GameObject Player;
    public GameObject end;
    public Camera PlayerCamera;
    public Camera endAnimation;

    private bool hasCollide = false;

    private int timer = 0;

    private void Start()
    {
        endAnimation.gameObject.SetActive(false);
        end.gameObject.SetActive(false);
        Player.gameObject.SetActive(true);
        PlayerCamera.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Star")
        {
            GameObject go = Instantiate(pickupEffect, other.transform.position, Quaternion.identity);
            Destroy(go, 0.8f);
            nbStar++;
            Destroy(other.gameObject);

            end.gameObject.SetActive(true);
            endAnimation.gameObject.SetActive(true);
            Player.transform.position -= new Vector3(0, 5, 0);
            PlayerCamera.gameObject.SetActive(false);
            end.GetComponent<Animator>().SetBool("launch", true);

            hasCollide = true;
        }
    }

    void FixedUpdate()
    {
        if (hasCollide == true)
        {
            timer++;
            endAnimation.gameObject.SetActive(true);
            PlayerCamera.gameObject.SetActive(false);
        }

        if (timer > 250)
        {
            SceneManager.LoadScene("menu");
        }
    }
}
