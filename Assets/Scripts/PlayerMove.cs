using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] float leftRightSpeed = 5f;
    [SerializeField] Animator player;
    [SerializeField] float jumpForce = 3f;
    [SerializeField] float waitTime = 0.35f;

    Vector3 moveDistance;
    static public bool canMove = false;
    bool isJumping = false;
    bool comingDown = false;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if(canMove == true)
        {
            Move();
        }
    }

    /*
    void OnMove(InputValue value)
    {
        moveDistance = value.Get<Vector3>();
        Debug.Log(moveDistance);
        //transform.Translate(new Vector3(transform.position.x + moveDistance.x, transform.position.y) * Time.deltaTime * leftRightSpeed); //can do using velocity
    }
    */
    
    void Move()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * leftRightSpeed * Time.deltaTime);
            }
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.right * leftRightSpeed * Time.deltaTime * -1);
            }
        }
        if(Input.GetKey(KeyCode.Space))
        {
            if(isJumping == false)
            {
                isJumping = true;
                player.SetTrigger("Jump");
            }
        }
        if(isJumping == true)
        {
            if(comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpForce, Space.World);
                StartCoroutine(JumpSequence());
            }
            if(comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -jumpForce, Space.World);
            }
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(waitTime);
        comingDown = true;
        yield return new WaitForSeconds(waitTime);
        comingDown = false;
        isJumping = false;
    }
    

}