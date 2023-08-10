using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChair : MonoBehaviour
{

    public GameObject center;
    public GameObject indicator;

    private Vector3 offset = Vector3.zero;

    private void Start()
    {
        offset = center.transform.position - indicator.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = center.transform.position.z - indicator.transform.position.z - offset.z;
        Debug.Log(distance);
        transform.Rotate(0, distance * Time.deltaTime, 0);
    }
}
