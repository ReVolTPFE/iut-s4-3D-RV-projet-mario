using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCatch : MonoBehaviour
{
    public int nbStar = 0;
    public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Star") // on a touch� une �toile
        {
            GameObject go = Instantiate(pickupEffect, other.transform.position, Quaternion.identity);
            Destroy(go, 0.8f);
            nbStar++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "coin") // on a touch� une piece
        {
            PlayerInfos.pi.GetCoin();
            Destroy(other.gameObject);
        }
    }
}

