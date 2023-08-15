using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChair : MonoBehaviour
{

    public GameObject center;
    public GameObject indicator;
    public GameObject indicatorF;


    private float angle = 0f;
    public float speed = 0f;
    private float initialPosition = 0f;

    private void Start()
    {
        initialPosition = indicator.transform.position.y - center.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, speed * Time.deltaTime, 0f));
    }
}
