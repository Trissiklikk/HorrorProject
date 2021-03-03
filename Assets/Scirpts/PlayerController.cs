using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject onOffFlashlight;
    private bool checkFlashlightOn = false;
    public float mouseSensitivity = 900f;
    public float movementSpeed = 10f;
    public Transform playerBody;
    public CharacterController controller;
    public float xRotation = 0f;
    private float gravity = -9.81f;
    //public AudioSource  soundFootstep;
    

    public static bool disableMovementPlayer = true;

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisableMovementPlayer",5.0f);
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(disableMovementPlayer == false)
        {
            LookAround();
            CharacterMovement();
            CharacterCrouch();
            CharacterFlashlight();  
            //FootstepSound();
            
        }

        
    }

    void LookAround()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation , -90f ,90f);

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
    void CharacterMovement()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * movementSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    
        
    }
    void CharacterCrouch()
    {
        if(Input.GetKey(KeyCode.LeftControl))
        {
            controller.GetComponent<CharacterController>().height = 0.5f;
        }
        else
        {
            controller.GetComponent<CharacterController>().height = 1.5f;
        }
    }
    void CharacterFlashlight()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(checkFlashlightOn == false)
            {
                onOffFlashlight.GetComponent<Light>().enabled = true;
                checkFlashlightOn = true;
            }
            else
            {
                onOffFlashlight.GetComponent<Light>().enabled = false;
                checkFlashlightOn = false;
            }
            
        }
    }

    void DisableMovementPlayer()
    {
        if(disableMovementPlayer == false)
        {
            disableMovementPlayer = true;
        }
        else
        {
            disableMovementPlayer = false;
        }
    }

    //void FootstepSound()
    //{
     //   if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
     //   {
     //       soundFootstep.Play();
     //       Debug.Log("Start");
     //   }
  //  }

}
