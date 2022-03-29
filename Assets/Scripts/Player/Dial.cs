using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dial : MonoBehaviour
{
    public GameObject Image;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Toad") // on a touché un toad 
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject go = Instantiate(Image, other.transform.position, Quaternion.identity);
                Destroy(go, 5f);
                print("tada");
            }
        }
    }
}
