using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwich : MonoBehaviour
{   
    private float theDistance;
    public GameObject lightObject;
    public GameObject textOnOffLight;
    public bool lightIsOn ;
    public GameObject lightAnimation;
    [SerializeField] public static bool isBroken = false;
    public GameObject textTellIsBroken;
    public AudioSource soundOnOff;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;


    }

    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textOnOffLight.SetActive(true);
            
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(theDistance <= 2 && isBroken == false)
            {
                if(lightIsOn == false)
                {
                    lightAnimation.GetComponent<Animation>().Play("LightSwichOff");
                    lightObject.GetComponent<Light>().enabled = true;
                    lightIsOn = true;
                    soundOnOff.Play();
                    textOnOffLight.SetActive(false);
                    

                }
                else
                {
                    lightAnimation.GetComponent<Animation>().Play("LightSwichOn");
                     lightObject.GetComponent<Light>().enabled = false;
                     lightIsOn = false;
                     soundOnOff.Play();
                     textOnOffLight.SetActive(false);
                     
                }
                
            }
            else
            {
                
                textTellIsBroken.SetActive(true);
            }
        }
    }
    void OnMouseExit()
    {
        textOnOffLight.SetActive(false);
        textTellIsBroken.SetActive(false);
    }
}
