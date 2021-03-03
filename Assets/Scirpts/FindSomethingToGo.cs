using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindSomethingToGo : MonoBehaviour
{

    public float theDistance;
    public GameObject textCantGo;





    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerRaycast.distanceFromTarget;

    }
    void OnMouseOver()
    {
        if (theDistance <= 1)
        {
            textCantGo.SetActive(true);

        }

    }
    void OnMouseExit()
    {

        textCantGo.SetActive(false);
    }
}
