using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWheelHitBox : MonoBehaviour
{

    public string direction;

    private bool isInside = false;
    private GameObject newCollider;
    private RotateChair rotateChair;

    private void Start()
    {
        rotateChair = GameObject.FindObjectOfType<RotateChair>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if (other.gameObject.CompareTag("Volante"))
            {
                isInside = true;
                newCollider = other.gameObject;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.CompareTag("Volante"))
            {
                isInside = false;
                newCollider = null;
                if(rotateChair != null)
                {
                    rotateChair.speed = 0f;
                }
            }
        }
    }

    private void Update()
    {
        if (isInside) {
            if(rotateChair != null )
            {
                switch (direction)
                {
                    case "L":
                        {
                            rotateChair.speed = (transform.position.x - (transform.position.x - newCollider.transform.position.x)) * 2f;
                            break;
                        }

                    case "R":
                        {
                            rotateChair.speed = (transform.position.x - (transform.position.x - newCollider.transform.position.x)) * -2f;
                            break;
                        }
                }
            }
        }

           
    }

}
