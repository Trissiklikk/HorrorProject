using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    //public GameObject nextTextComing;
    public GameObject[] objectSpawn;



    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            for (int i = 0; i < objectSpawn.Length; i++)
            {
                objectSpawn[i].SetActive(true);

            }

        }

    }

}
