using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLight : MonoBehaviour
{


    //public GameObject lightObject;
    public GameObject[] lightObjectClose;
    public bool cantOpen = false;
    public GameObject[] lightOpen;
    public GameObject lightFlicker;
    

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (cantOpen == false)
            {

                for (int i = 0; i < lightObjectClose.Length; i++)
                {
                    lightObjectClose[i].GetComponent<Light>().enabled = false;
                    //Debug.Log(i);
                }

                Invoke("LightOn", 3f);
            }
            else
            {
                LightSwich.isBroken = true;
                
                StartCoroutine(Flashing());
                
                for (int i = 0; i < lightObjectClose.Length; i++)
                {
                    lightObjectClose[i].GetComponent<Light>().enabled = false;
                    //Debug.Log(i);
                }
                for (int j = 0; j < lightOpen.Length; j++)
                {
                    lightOpen[j].GetComponent<Light>().enabled = true;

                }
            }

        }

    }

    void LightOn()
    {
        for (int i = 0; i < lightObjectClose.Length; i++)
        {
            lightObjectClose[i].GetComponent<Light>().enabled = true;
            //Debug.Log(i);



        }
    }
    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f,2f));
            lightFlicker.GetComponent<Light>().enabled = !lightFlicker.GetComponent<Light>().enabled;
        }
    }



}
