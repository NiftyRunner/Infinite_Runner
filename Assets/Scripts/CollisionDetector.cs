using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Animator playerAnimator;
    [SerializeField] Animator cameraAnimator;
    [SerializeField] AudioSource crashSource;
    [SerializeField] GameObject levelControl;

    void OnTriggerEnter(Collider other) 
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMove>().enabled = false;
        levelControl.GetComponent<DistanceMeasure>().enabled = false;    
        playerAnimator.SetTrigger("isDead");
        cameraAnimator.Play("CameraShake 0");
        crashSource.Play();
        levelControl.GetComponent<LevelEndScreen>().enabled = true;
    }
}
