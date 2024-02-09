using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ParpadearTextoS : MonoBehaviour
{
    private TextMeshProUGUI texto;

    // Configuración del parpadeo
    public float velocidadParpadeo = 1.0f; // Cuántas veces parpadea por segundo

    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        StartCoroutine(Parpadear());
    }

    IEnumerator Parpadear()
    {
        while (true)
        {
            // Cambiar el color a transparente
            texto.color = new Color(texto.color.r, texto.color.g, texto.color.b, 0f);

            // Esperar un breve momento
            yield return new WaitForSeconds(1 / velocidadParpadeo);

            // Cambiar el color a opaco
            texto.color = new Color(texto.color.r, texto.color.g, texto.color.b, 1f);

            // Esperar otro breve momento
            yield return new WaitForSeconds(1 / velocidadParpadeo);
        }
    }
}
