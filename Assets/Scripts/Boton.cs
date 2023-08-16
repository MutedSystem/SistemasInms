using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Transform objetoADetectar;
    public float distanciaMinima = 0.2f;
    public GameObject objetoAMover;
    public float velocidadMovimiento = 1.0f;
    public float distanciaMaximaMovimiento = 1.0f;

    private Vector3 posicionOriginal;
    private bool isPressed = false; // Indica si el botón está presionado

    private void Start()
    {
        posicionOriginal = objetoAMover.transform.position;
    }

    private void Update()
    {
        float distancia = Vector3.Distance(transform.position, objetoADetectar.position);

        if (distancia <= distanciaMinima)
        {
            Debug.Log("Boton Presionado");
            isPressed = true;
        }
        else
        {
            Debug.Log("Boton No Presionado");
            isPressed = false;
        }

        if (isPressed)
        {
            MoverObjetoAbajo();
        }
        else
        {
            MoverObjetoArriba();
        }
    }

    private void MoverObjetoAbajo()
    {
        if (objetoAMover.transform.position.y > posicionOriginal.y - distanciaMaximaMovimiento)
        {
            objetoAMover.transform.Translate(Vector3.down * velocidadMovimiento * Time.deltaTime);
        }
    }

    private void MoverObjetoArriba()
    {
        if (objetoAMover.transform.position.y < posicionOriginal.y)
        {
            objetoAMover.transform.Translate(Vector3.up * velocidadMovimiento * Time.deltaTime);
        }
    }
}
