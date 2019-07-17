using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public playerController controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;


    public Joystick joy;
    public Animator anim;
    public void Start()
    {
        controller = FindObjectOfType<playerController>();
    }
    
    // Start is called before the first frame update
    void Update()
    {

        anim.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (joy.Horizontal >= 0.2f)
        {
            horizontalMove = runSpeed;
            
        }
        else if (joy.Horizontal <= -0.2f) { horizontalMove = -runSpeed; }
        else { horizontalMove = 0; }
        float verticalMove = joy.Vertical;
        if (verticalMove >= 0.6f)
        {
            controller.m_JumpForce = 200f;
            jump = true;
            anim.SetBool("IsJumping", true);
        }



    }


    // Update is called once per frame
    void FixedUpdate()
    {
  
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        
        jump = false;
    }
    public void OnLanding()
    {
        anim.SetBool("IsJumping", false);
    }

}
