using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuko : MonoBehaviour
{
    private CharacterController wukong;
    private float speed;
    private float forspeed;
    private float flyspeed; 
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        wukong = GetComponent<CharacterController>();
        speed = 60f;
        flyspeed = 30f;
        animator = GetComponent<Animator>();
        forspeed = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (Mathf.Abs(h) > 0.1f || Mathf.Abs(v) > 0.1)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * 50F * Time.deltaTime);
            }
            else
            {

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    wukong.SimpleMove(transform.forward * speed * Time.deltaTime * 6);
                }
                else
                {
                    if (Input.GetKey(KeyCode.S))
                    {
                        wukong.SimpleMove(transform.forward * -1 * speed * Time.deltaTime);
                    }
                    else
                    {
                        if (Input.GetKey(KeyCode.W))
                        {
                            wukong.SimpleMove(transform.forward * speed * Time.deltaTime);
                        }
                    }
                }
            }
        }
        if (Input.GetKey(KeyCode.U))
        {
            wukong.Move(transform.up * flyspeed * Time.deltaTime);
            wukong.Move(transform.forward * forspeed * Time.deltaTime);
        }
        else
        {
            wukong.Move(transform.up * -1 * 30f * Time.deltaTime);
        }

    }
}

