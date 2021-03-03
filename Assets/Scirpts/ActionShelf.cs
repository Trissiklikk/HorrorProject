using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionShelf : MonoBehaviour
{
    public float theDistance;
    public GameObject textForDoor;
    public GameObject door;
    private bool doorIsOpen = false;
    


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
            if(theDistance <= 2)
            {
                if(doorIsOpen == false)
                {
                    door.GetComponent<Animation>().Play("DoorOpen");
                    doorIsOpen = true;
                }
                else
                {
                    door.GetComponent<Animation>().Play("DoorClose");
                    doorIsOpen = false;
                }
                
            }
        }
        

    }
   void OnMouseExit()
    {
        textForDoor.SetActive(false);
    }
}
