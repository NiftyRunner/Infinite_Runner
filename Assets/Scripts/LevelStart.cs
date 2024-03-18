using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject countDown3;
    [SerializeField] GameObject countDown2;
    [SerializeField] GameObject countDown1;
    [SerializeField] GameObject countDownGo;

    void Start()
    {
        StartCoroutine(CountSequenece());
    }

    IEnumerator CountSequenece()
    {
        yield return new WaitForSeconds(1.5f);

        
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown3.SetActive(false);
        
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(false);

        countDown1.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(false);

        countDownGo.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDownGo.SetActive(false);

        PlayerMove.canMove = true;
    }

}
