using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public float velocidadSeguimiento = 5f;

    void Update()
    {
        // Obt�n la posici�n actual de la c�mara
        Vector3 posicionCamara = transform.position;

        // Calcula la nueva posici�n en el eje x siguiendo al objeto
        float nuevaPosicionX = Mathf.Lerp(posicionCamara.x, target.position.x, velocidadSeguimiento * Time.deltaTime);

        // Asigna la nueva posici�n manteniendo la posici�n actual en los otros ejes
        transform.position = new Vector3(nuevaPosicionX, posicionCamara.y, posicionCamara.z);
    }
}
