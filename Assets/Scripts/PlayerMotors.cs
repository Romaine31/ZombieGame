using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotors : MonoBehaviour
{
    private CharacterController contoller;
    private Vector3 playerVelocity;
    private bool isGrounded;
    private bool lerpCrouch;
    private bool crouching;
    private bool sprinting;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    public float crouchTimer;
    // Start is called before the first frame update
    void Start()
    {
        contoller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = contoller.isGrounded;
        if (lerpCrouch){
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / 1;
            p *= p;
            if(crouching)
                contoller.height = Mathf.Lerp(contoller.height, 1, p);
            else
                contoller.height = Mathf.Lerp(contoller.height, 2, p);

            if(p > 1){
                lerpCrouch = false;
                crouchTimer = 0f;
            }
        }
    }
    public void Crouch(){
        crouching = !crouching;
        crouchTimer = 0;
        lerpCrouch = true;
    }
    public void Sprint(){
        sprinting = !sprinting;
        if(sprinting)
            speed = 8;
        else
            speed = 5;
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        contoller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if(isGrounded && playerVelocity.y < 0)
            playerVelocity.y = -2f;
        contoller.Move(playerVelocity * Time.deltaTime);
        Debug.Log(playerVelocity.y);
    }

    public void Jump() 
    {
        if(isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }

    }
}
