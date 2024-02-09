using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
    
    private bool espacioPresionado = false;

    void Update()
    {
        // Detectar si se presiona la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivarDesactivarParticulas(true);
            espacioPresionado = true;
        }

        // Detectar si se suelta la tecla de espacio
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ActivarDesactivarParticulas(false);
            espacioPresionado = false;
        }
    }

    void ActivarDesactivarParticulas(bool activar)
    {
        // Obtener todas las part�culas con el tag "particulas_cohete"
        GameObject[] particulas = GameObject.FindGameObjectsWithTag("particulas_cohete");

        // Activar o desactivar las part�culas seg�n el valor de 'activar'
        foreach (GameObject particula in particulas)
        {
            ParticleSystem sistemaParticulas = particula.GetComponent<ParticleSystem>();
            if (sistemaParticulas != null)
            {
                if (activar)
                {
                    sistemaParticulas.Play();
                }
                else
                {
                    sistemaParticulas.Stop();
                }
            }
        }
    }
}