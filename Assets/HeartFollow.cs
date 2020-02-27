using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartFollow : MonoBehaviour
{
    private Transform playertransform;
    void Start()
    {
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = playertransform.position.x;
        transform.position = temp;


    }
}
