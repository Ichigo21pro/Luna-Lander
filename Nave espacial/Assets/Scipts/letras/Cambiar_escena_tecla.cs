using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiar_escena_tecla : MonoBehaviour
{
    public string nombreDeEscena = "Juego"; // Nombre de la escena a la que quieres ir

    void Update()
    {
        if (Input.anyKeyDown)
        {
            // Se ha presionado cualquier tecla, cambiar a la escena especificada
            SceneManager.LoadScene(nombreDeEscena);
        }
    }
}
