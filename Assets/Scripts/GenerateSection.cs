using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSection : MonoBehaviour
{
    public GameObject[] section;
    [SerializeField] float zPos = 50f;
    bool isGeneratingSection = false;
    [SerializeField] int secNum;

    void Update()
    {
        if(isGeneratingSection == false)
        {
            isGeneratingSection = true;
            StartCoroutine(GeneratingSection());
        }        
    }

    IEnumerator GeneratingSection()
    {
        secNum = UnityEngine.Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(6);
        isGeneratingSection = false;
    }
}
