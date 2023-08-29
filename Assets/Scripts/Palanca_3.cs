using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca_3 : MonoBehaviour
{

    private GameObject referenceObject;
    private GameObject referenceObjectCenter;
    private GameObject chairCenter;

    private float returnSpeed = 0.2f;

    public bool isGoingBack = false;

    public float scaleFactor = 1f;

    // Start is called before the first frame update
    void Start()
    {
        referenceObject = GameObject.Find("ReferencePointEnd");
        referenceObjectCenter = GameObject.Find("ReferencePointStart");
        chairCenter = GameObject.Find("CentroSilla");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = (referenceObject.transform.position - chairCenter.transform.position);
        this.transform.position = new Vector3(newPosition.x * scaleFactor, referenceObject.transform.position.y , newPosition.z * scaleFactor);
        transform.LookAt(referenceObjectCenter.transform);

        if (isGoingBack && scaleFactor >= 0.25f)
            scaleFactor -= returnSpeed * Time.deltaTime;
        if (!isGoingBack && scaleFactor < 1.0f)
            scaleFactor += returnSpeed * Time.deltaTime;

    }
}
