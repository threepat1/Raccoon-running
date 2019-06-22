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

        horizontalMove = joy.Horizontal * runSpeed;

        anim.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (joy.Vertical >= 0.1 || Input.GetKeyUp(KeyCode.Space))
        {

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
