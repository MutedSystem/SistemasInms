using UnityEngine;

public class bloquear : MonoBehaviour
{
    public bool bloquearTraslacionX;
    public bool bloquearTraslacionY;
    public bool bloquearTraslacionZ;

    public bool bloquearRotacionX;
    public bool bloquearRotacionY;
    public bool bloquearRotacionZ;

    public bool bloquearEscalaX;
    public bool bloquearEscalaY;
    public bool bloquearEscalaZ;

    private Vector3 posicionInicial;
    private Quaternion rotacionInicial;
    private Vector3 escalaInicial;

    private void Start()
    {
        // Guardar la posición, rotación y escala iniciales del objeto
        posicionInicial = transform.position;
        rotacionInicial = transform.rotation;
        escalaInicial = transform.localScale;
    }

    private void Update()
    {
        // Aplicar bloqueo de traslación, rotación y escala según las opciones seleccionadas
        Vector3 nuevaPosicion = new Vector3(
            bloquearTraslacionX ? posicionInicial.x : transform.position.x,
            bloquearTraslacionY ? posicionInicial.y : transform.position.y,
            bloquearTraslacionZ ? posicionInicial.z : transform.position.z
        );

        Quaternion nuevaRotacion = new Quaternion(
            bloquearRotacionX ? rotacionInicial.x : transform.rotation.x,
            bloquearRotacionY ? rotacionInicial.y : transform.rotation.y,
            bloquearRotacionZ ? rotacionInicial.z : transform.rotation.z,
            transform.rotation.w
        );

        Vector3 nuevaEscala = new Vector3(
            bloquearEscalaX ? escalaInicial.x : transform.localScale.x,
            bloquearEscalaY ? escalaInicial.y : transform.localScale.y,
            bloquearEscalaZ ? escalaInicial.z : transform.localScale.z
        );

        transform.position = nuevaPosicion;
        transform.rotation = nuevaRotacion;
        transform.localScale = nuevaEscala;
    }
}
