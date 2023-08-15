using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantsUtils : MonoBehaviour
{

    public GameObject center;
    public float mainRotation = 0f;


    // Update is called once per frame
    void Update()
    {
        mainRotation = Mathf.Atan2(center.transform.transform.position.z, center.transform.position.x);        
    }
}
