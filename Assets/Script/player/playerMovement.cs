using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public playerController controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    public Animator anim;

    // Start is called before the first frame update
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        anim.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if(Input.GetButtonUp("Jump"))
        {
            jump = true;
            anim.SetBool("IsJumping", true);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void OnLanding()
    {
        anim.SetBool("IsJumping", false);
    }
}
