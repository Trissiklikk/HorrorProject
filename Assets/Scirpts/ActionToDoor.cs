using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionToDoor : MonoBehaviour
{
    public float theDistance;
    public GameObject textForDoor;
    public GameObject door;
    private bool doorIsOpen = false;
    public bool doorIsLock ;
    public GameObject textDoorIslock;
    public int indexDoor;
    public AudioSource soundOpenDoor;
    public AudioSource soundCloseDoor;
    public AudioSource soundSlammingDoor;
    


    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;

    }
    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textForDoor.SetActive(true);
            
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(theDistance <= 2 && PlayerInventory.keys[indexDoor] == true)
            {
                if(doorIsOpen == false)
                {
                    door.GetComponent<Animation>().Play("DoorOpen");
                    soundOpenDoor.Play();
                    doorIsOpen = true;
                }
                else
                {
                    door.GetComponent<Animation>().Play("DoorClose");
                    soundCloseDoor.Play();
                    doorIsOpen = false;
                }
                
            }
            else if(theDistance <= 2)
            {
                textDoorIslock.SetActive(true);

            }
        }
        

    }
   void OnMouseExit()
    {
        textForDoor.SetActive(false);
        textDoorIslock.SetActive(false);
    }
}
