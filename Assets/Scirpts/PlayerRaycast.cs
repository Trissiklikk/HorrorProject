using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public static float distanceFromTarget;
    public float toTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DistancePlayerToTarget();
        
    }

        void DistancePlayerToTarget()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = toTarget;
        }

    }
}
