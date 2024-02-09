using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido_Impulse_space : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Obtén la referencia al componente AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Verifica si se ha pulsado la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Reproduce el sonido
            audioSource.Play();
        }

        // Verifica si se ha soltado la barra espaciadora
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Detiene el sonido
            audioSource.Stop();
        }
    }
}
