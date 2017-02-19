using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyTest : MonoBehaviour {

    private float speed = 4f;
    public Transform playergraphic;

    void Update()
    {
        Movement();
    }

    void Movement()
    {

        //Player object movement
        float horMovement = -Input.GetAxisRaw("Horizontal1");
        float vertMovement = Input.GetAxisRaw("Vertical1");
        if (horMovement != 0 && vertMovement != 0)
        {
            //speed = 1.0f;
            speed = 3.0f;

        }
        else
        {
            //speed = 1.5f;
            speed = 5f;

        }
        transform.Translate(transform.right * horMovement * Time.deltaTime * speed);
        transform.Translate(transform.forward * vertMovement * Time.deltaTime * speed);

        //Player graphic rotation
        Vector3 moveDirection = new Vector3(horMovement, 0, vertMovement);
        if (moveDirection != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            playergraphic.transform.rotation = Quaternion.Slerp(playergraphic.transform.rotation, newRotation, Time.deltaTime * 8);
        }
        
        /*
        //Player graphic animation
        if (moveDirection.magnitude > 0.05f)
        {
            playergraphic.GetComponent<Animation>().CrossFade("walk", 0.2f);
        }
        else
        {
            playergraphic.GetComponent<Animation>().CrossFade("idle", 0.2f);
        }
        */
    }
}

