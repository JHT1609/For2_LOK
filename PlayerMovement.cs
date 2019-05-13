using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;    //Setur CharacterContoller2D script sem controller

    public float runSpeed = 40f;    //Setur Default Runspeed sem 40f

    float horizontalMove = 0f;

    bool jump = false;      //passar að character er ekki stanslaust að hoppa eða skríða
    bool crouch = false;

    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; //Movement speed er áttin sem er að fara * runspeed floatið

        if (Input.GetButtonDown("Jump"))    //ef jump takkin er ýttur, á player að stökkva
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }

        else if (Input.GetButtonUp("Crouch"))   //ef ekki er verið að ýta á crouch takka er crouch aftur false
        {
            crouch = false;
        }

    }

    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);    //Player Hoppar í áttina sem hann er að horfa og kíkir svo hvort player vill aftur hoppa eða skríða
        jump = false;
    }
}
