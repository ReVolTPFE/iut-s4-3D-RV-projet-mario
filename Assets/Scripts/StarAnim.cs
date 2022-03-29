using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnim : MonoBehaviour
{
    public Vector3 dir;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(dir * Time.deltaTime);
    }
}
