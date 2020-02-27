using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    [SerializeField] public GameObject blockageCoins;
   
     public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            blockageCoins.gameObject.SetActive(false);
        }
    } 
}
