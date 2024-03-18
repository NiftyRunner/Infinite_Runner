using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistanceMeasure : MonoBehaviour
{
    [SerializeField] GameObject disDisplay;
    [SerializeField] GameObject disEndDisplay;
    [SerializeField] float waitTime = 0.35f;
    
    public int disRun;
    public bool addingDis = false;

    void Update()
    {
        if(addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<TextMeshProUGUI>().text = "" + disRun;
        disEndDisplay.GetComponent<TextMeshProUGUI>().text = "" + disRun;
        yield return new WaitForSeconds(waitTime);
        addingDis = false;
    }
}
