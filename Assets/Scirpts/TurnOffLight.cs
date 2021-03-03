using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLight : MonoBehaviour
{

    
    //public GameObject lightObject;
    public GameObject[] lightObject;
    public bool cantOpen = false;



    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            if(cantOpen == false)
            {

               for(int i = 0; i < lightObject.Length; i++)
               {
                   lightObject[i].SetActive(false);
                    //Debug.Log(i);
               }

                  Invoke("LightOn",3f);
            }
            else
            {
                LightSwich.isBroken = true;
                for(int i = 0; i < lightObject.Length; i++)
               {
                   lightObject[i].SetActive(false);
                    //Debug.Log(i);
               }
            }

        }

    }

    void LightOn()
    {
        for(int i = 0; i < lightObject.Length; i++)
            {
                lightObject[i].SetActive(true);
                //Debug.Log(i);
                

                
            }
    }


    
}
