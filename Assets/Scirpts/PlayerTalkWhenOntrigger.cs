using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTalkWhenOntrigger : MonoBehaviour
{
    public Text textWarningA = null;
    public Text textWarningB = null;
    public string inputPlayerText = null;
    private string textCheckNull = "";
    public GameObject nextTextComing;
    //public float timeInput;
   


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player" )
        {
            if(textWarningA.text == textCheckNull)
            {
                textWarningB.text = textCheckNull;
                textWarningA.text = inputPlayerText;
                nextTextComing.SetActive(true);  
                gameObject.SetActive(false);
                Invoke("ClearTextA",5f);
                Debug.Log("A");
                
            }
            else if(textWarningA.text != textCheckNull)
            {
                textWarningB.text = inputPlayerText;
                textWarningA.text = textCheckNull;
                nextTextComing.SetActive(true); 
                gameObject.SetActive(false);
                Invoke("ClearTextB",5f);
                Debug.Log("B");
            }
            
        }
       
    }

    void ClearTextA()
    {
        if(textWarningA.text != textCheckNull)
        {
            textWarningA.text = textCheckNull;
        }
        
    }
      void ClearTextB()
    {
        if(textWarningB.text != textCheckNull)
        {
            textWarningB.text = textCheckNull;  
        }
        
    }

   
}
