using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    string currentCoin;
    public static int coinCount = 0;
    [SerializeField] GameObject coinText;
    [SerializeField] GameObject endCoinText;

    void Start() 
    {
        //currentCoin = 
        //currentCoin = "" + 0;    
    }

    void Update()
    {
        endCoinText.GetComponent<TextMeshProUGUI>().text = "" + coinCount; 
        coinText.GetComponent<TextMeshProUGUI>().text = "" + coinCount; 
    }
}
