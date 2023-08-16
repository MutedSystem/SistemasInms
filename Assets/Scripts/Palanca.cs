using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
    public GameObject objetoAMover;
    public float velocidadMovimiento = 1.0f;
    public float distanciaMaximaMovimiento = 1.0f;

    private Vector3 posicionOriginal; // Almacenará la posición original del objeto
    private Vector3 ultimaPosicion; // Almacenará la última posición del GameObject

    private void Start()
    {
        posicionOriginal = objetoAMover.transform.position; // Guarda la posición original al inicio
        ultimaPosicion = transform.position; // Inicializa la última posición con la posición original
    }

    private void Update()
    {
        // Calcula el vector de movimiento desde la última posición
        Vector3 movimiento = transform.position - ultimaPosicion;

        // Comprueba si hay movimiento
        if (movimiento.magnitude > 0)
        {
            Debug.Log("Boton Movido");
            MoverObjeto(movimiento.normalized); // Mueve el objeto en la dirección del movimiento
            ultimaPosicion = transform.position; // Actualiza la última posición
        }
        else
        {
            Debug.Log("Boton en Reposo");
            MoverObjeto(Vector3.zero); // Detiene el movimiento del objeto
        }
    }

    private void MoverObjeto(Vector3 direccion)
    {
        Vector3 nuevaPosicion = objetoAMover.transform.position + direccion * velocidadMovimiento * Time.deltaTime;

        // Limita el movimiento a una distancia máxima desde la posición original
        float distanciaDesdeOrigen = Vector3.Distance(objetoAMover.transform.position, posicionOriginal);
        if (distanciaDesdeOrigen <= distanciaMaximaMovimiento)
        {
            objetoAMover.transform.position = nuevaPosicion;
        }
    }
}
