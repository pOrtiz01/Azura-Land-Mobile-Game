using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFollow : MonoBehaviour
{
    private Transform playertransform;
    void Start()
    {
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x = playertransform.position.x-38;
        transform.position = temp;
    }
}
