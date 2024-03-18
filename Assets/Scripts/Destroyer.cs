using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] float waitTime = 30f;
    string parentName;

    void Start()
    {
        parentName = transform.name;
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(waitTime);
        if(parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }

    }
}
