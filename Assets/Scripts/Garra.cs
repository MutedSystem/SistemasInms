using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garra : MonoBehaviour
{
    public GameObject targetObject; // Asigna el objeto de destino desde el Inspector
    public GameObject releaseObject; // Asigna el objeto de liberación desde el Inspector
    private bool isColliding = false;
    private Vector3 initialOffset;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject && !isColliding)
        {
            isColliding = true;

            // Calcula la posición relativa entre los objetos
            initialOffset = transform.position - targetObject.transform.position;

            // Desactiva la gravedad del objeto jugador para que no caiga
            GetComponent<Rigidbody>().useGravity = false;
        }
        else if (other.gameObject == releaseObject && isColliding)
        {
            isColliding = false;

            // Activa la gravedad del objeto jugador nuevamente
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void Update()
    {
        if (isColliding)
        {
            // Actualiza la posición del objeto jugador en función de la posición relativa inicial
            transform.position = targetObject.transform.position + initialOffset;
        }
    }
}
