using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static bool[] keys = new bool [6];
    //0 = normal Door
    //1 = bathroom Door
    //3 = desk Door
    //4 = cabinet Door
    //6 = Unlock Sound Event

    void Awake()
    {
        keys[0] = true;
    }
}
