using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockTable : MonoBehaviour
{
    public int indexToUnlock;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            PlayerInventory.keys[indexToUnlock] = true;
        }
    }
}
