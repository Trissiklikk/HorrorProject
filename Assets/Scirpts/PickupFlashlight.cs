using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFlashlight : MonoBehaviour
{
    private float theDistance;
    public GameObject textPickUpItem;
    public GameObject flashlightModel;
    public GameObject flashlightOnplayer;
    public GameObject unlockTheWay;
    


    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;


    }

    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textPickUpItem.SetActive(true);
            
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(theDistance <= 2)
            {
                unlockTheWay.SetActive(false);

                flashlightModel.SetActive(false);
                flashlightOnplayer.SetActive(true);
                textPickUpItem.SetActive(false);
             
            }
        }
    }
    void OnMouseExit()
    {
        textPickUpItem.SetActive(false);
    }
}
