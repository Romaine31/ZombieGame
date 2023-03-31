using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //gravity
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 10f;

    //physics check
    public Transform groundCheck;
    public float groundRadius = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    //sprinting
    public bool isSprinting = false;
    public float sprintingMultiplier;
    


    //if in the ground
    bool isGrounded;


    //debugger
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gravity and create an invisible sphere
        isGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, layerMask: groundMask);

        if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }


        //get horizontal and vertical input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        

        //jump command
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            Debug.Log("Jump");
        }

        //sprinting command
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }

        if (isSprinting == true)
        {
            move *= sprintingMultiplier;
            
        }

        //crouching command
       if (Input.GetKeyDown(KeyCode.C))
          {
              transform.localScale = new Vector3(0.5f, 0.60f, 0.5f);
          }
          else
          {
              transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
          }
        //gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(move*speed*Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
    }
    
}
