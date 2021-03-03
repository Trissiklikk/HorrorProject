using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockWay : MonoBehaviour
{
    public float theDistance;
    public string inputText;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                TextSystem.textNext = inputText;
            }
            
        }

    }
   void OnMouseExit()
    {
       TextSystem.textNext = null;
    }
}
