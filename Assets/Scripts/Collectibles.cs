using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] int rotateSpeed = 1;

    [SerializeField] AudioSource SFX;
    
    void Update()
    {
        transform.Rotate(0 , rotateSpeed, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.tag == "Coin")
        {
            SFX.Play();
            CoinCount.coinCount += 1;
            this.gameObject.SetActive(false);
        }
    }
}
