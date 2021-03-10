using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSystem : MonoBehaviour
{

    public GameObject textPrefab;
    //private Text text_Prefab;
    private GameObject newTextPrefab;
    public GameObject textLayer;
    public static string textNext;
    

    //public GameObject[] text;
    void Update()
    {

        if (textNext != null)
        {
            newTextPrefab = GameObject.Instantiate(textPrefab);
            newTextPrefab.GetComponent<Text>().text = textNext;


            newTextPrefab.transform.parent = GameObject.Find("TextLayer").transform;
            //Instantiate(textPrefab ,textLayer.transform.position,Quaternion.identity);
            textNext = null;

        }
    }

}

