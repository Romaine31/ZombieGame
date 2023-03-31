using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselookin : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    
    // Start is called before the first frame update
    void Start()
    {
        //will remove the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // get the x and y input axis
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        // will get movement
        xRotation -= mouseY;

        //clam the camera
        xRotation = Mathf.Clamp(xRotation, -90f , 90f);

        //vertical movement
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        //will rotate the camera frome left to right
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
