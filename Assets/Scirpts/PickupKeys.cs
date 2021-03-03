using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKeys : MonoBehaviour
{
    public float theDistance;
    public GameObject textForKeys;
    public GameObject keys;
    public GameObject soundKey;
    //public AudioSource soundKeyPickup;
    public int indexKeyOfDoor;

    


    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;

    }
    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textForKeys.SetActive(true);
            
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(theDistance <= 2)
            {
                PlayerInventory.keys[indexKeyOfDoor] = true;
                soundKey.GetComponent<AudioSource>().Play();
                textForKeys.SetActive(false);
                keys.SetActive(false);
                
                

            }
           
        }
        

    }
   void OnMouseExit()
    {
       textForKeys.SetActive(false);
    }
}
