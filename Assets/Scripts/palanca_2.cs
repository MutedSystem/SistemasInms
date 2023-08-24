using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palanca_2 : MonoBehaviour
{
    public GameObject objetoAMover;
    public float velocidadMovimiento = 1.0f;
    public float distanciaMaximaMovimiento = 1.0f;

    private Vector3 posicionOriginal; // Almacenar� la posici�n original del objeto
    private Vector3 ultimaPosicion; // Almacenar� la �ltima posici�n del GameObject

    private void Start()
    {
        posicionOriginal = objetoAMover.transform.position; // Guarda la posici�n original al inicio
        ultimaPosicion = transform.position; // Inicializa la �ltima posici�n con la posici�n original
    }

    private void Update()
    {
        // Calcula el vector de movimiento desde la �ltima posici�n
        Vector3 movimiento = transform.position - ultimaPosicion;

        // Comprueba si hay movimiento
        if (movimiento.magnitude > 0)
        {
            Debug.Log("Boton Movido");
            MoverObjeto(movimiento.normalized); // Mueve el objeto en la direcci�n del movimiento
            ultimaPosicion = transform.position; // Actualiza la �ltima posici�n
        }
        else
        {
            Debug.Log("Boton en Reposo");
            MoverObjeto(Vector3.zero); // Detiene el movimiento del objeto
        }
    }

    private void MoverObjeto(Vector3 direccion)
    {
        Vector3 nuevaPosicion = objetoAMover.transform.position + new Vector3(direccion.x, 0, 0) * velocidadMovimiento * Time.deltaTime;

        // Limita el movimiento a una distancia m�xima desde la posici�n original en el eje X
        float distanciaDesdeOrigen = Mathf.Abs(objetoAMover.transform.position.x - posicionOriginal.x);
        if (distanciaDesdeOrigen <= distanciaMaximaMovimiento)
        {
            objetoAMover.transform.position = nuevaPosicion;
        }
    }
}
