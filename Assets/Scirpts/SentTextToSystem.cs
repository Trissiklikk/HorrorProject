using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentTextToSystem : MonoBehaviour
{
    public bool closePlayerMovement;
    public float delayTime;
    public string[] textWantToShow;
    public GameObject nextTextComing;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            if (closePlayerMovement == true)
            {
                PlayerController.disableMovementPlayer = true;
                Invoke("EnablePlayerMovement",delayTime);
            }
            StartCoroutine(NewText());

            

        }
    }
    IEnumerator NewText()
    {

        WaitForSeconds wfs = new WaitForSeconds(2);
        for (int i = 0; i < textWantToShow.Length; i++)
        {
            TextSystem.textNext = textWantToShow[i];
            gameObject.GetComponent<BoxCollider>().enabled = false;
            nextTextComing.SetActive(true);

            yield return wfs;

        }
        
        
        gameObject.SetActive(false);



    }

    public void EnablePlayerMovement()
    {
        PlayerController.disableMovementPlayer = false;
    }

}
