using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationSnowBall : MonoBehaviour
{
    public float rotSpeed = 100f;
    private bool isWandering = false;
    private bool isRotL = false;
    private bool isRotR = false;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(Wander());
        }
        if (isRotR == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if (isRotL == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }     
    }

    IEnumerator Wander()
    {
        int rottime = Random.Range(1, 3);
        int rotwait = Random.Range(1, 3);
        int rotatelorR = Random.Range(1, 3);


        isWandering = true;

        yield return new WaitForSeconds(rotwait);
        if (rotatelorR == 1)
        {
            isRotR = true;
            yield return new WaitForSeconds(rottime);
            isRotR = false;
        }
        if (rotatelorR == 2)
        {
            isRotL = true;
            yield return new WaitForSeconds(rottime);
            isRotL = false;
        }
        isWandering = false;
    }
}
