using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePickUp : MonoBehaviour
{
    public float theDistance;
    public GameObject pickupText;
    public GameObject ButtonReadNote; 
    public Image Note;

    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            pickupText.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E))
            {
                
                Note.enabled = true;
                ButtonReadNote.SetActive(true);
                pickupText.SetActive(false);
                
            }
        }
    }
    void OnMouseExit()
    {
        pickupText.SetActive(false);
    }




}
