using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wukongmove : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isflying", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            animator.SetBool("isuping", true);
        }
        else
        {
            animator.SetBool("isuping", false);
        }
        if (Input.GetAxisRaw("Vertical")!=0 || Input.GetAxisRaw("Horizontal") != 0)
        {
            animator.SetBool("iswalking", true);
            if(Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isrunning", true);
            }
            else
            {
                animator.SetBool("isrunning", false);
            }

        }
        else
        {
            animator.SetBool("iswalking", false);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isjumping", true);
        }
        else
        {
            animator.SetBool("isjumping", false);
        }
       
    }
}
