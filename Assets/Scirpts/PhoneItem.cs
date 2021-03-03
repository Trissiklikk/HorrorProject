using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneItem : MonoBehaviour
{
    public GameObject phoneInPlayer;
    public float theDistance;
    public GameObject textForPhone;
    public GameObject phone;
    public GameObject soundPhone;
    //public AudioSource soundKeyPickup;
    public int indexKeyOfDoor;

    public GameObject nextTextComing;
    public GameObject objectSpawn;


    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;

    }
    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textForPhone.SetActive(true);
            
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(theDistance <= 2)
            {
                PlayerInventory.keys[indexKeyOfDoor] = true;
                soundPhone.GetComponent<AudioSource>().Play();
                phoneInPlayer.GetComponent<MeshRenderer>().enabled = true;
                phoneInPlayer.GetComponent<Animation>().Play("CallPhone");
                textForPhone.SetActive(false);
                objectSpawn.SetActive(true);  
                nextTextComing.SetActive(true);
                gameObject.SetActive(false);
                phone.SetActive(false);

            }
           
        }
        
    }
   void OnMouseExit()
    {
       textForPhone.SetActive(false);
    }
}
