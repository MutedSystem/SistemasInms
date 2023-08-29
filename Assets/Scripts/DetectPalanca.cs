using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPalanca : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.CompareTag("Palanca"))
            {
                Palanca_3 palanca = GameObject.FindObjectOfType<Palanca_3>();
                if(palanca != null)
                {
                    palanca.isGoingBack = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.CompareTag("Palanca"))
            {
                Palanca_3 palanca = GameObject.FindObjectOfType<Palanca_3>();
                if (palanca != null)
                {
                    palanca.isGoingBack = false;
                }
            }
        }
    }
}
