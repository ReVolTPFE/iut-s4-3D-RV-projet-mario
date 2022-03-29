using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfos : MonoBehaviour
{
    public static PlayerInfos pi;
    public int nbCoins = 0;

    private void Awake()
    {
        pi = this;
    }

    public void GetCoin()
    {
        nbCoins++;
    }

    // Update is called once per frame
    //    void Update()
    //    {

    //    }
}
