using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Base_Colision_mejorada : MonoBehaviour
{

    bool collisionDetected = false;
    float tiempo = 0;
    bool GameFinish = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cohete")
        {
            collisionDetected = true;
        }
        
           
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Cohete")
        {
            collisionDetected = false;
            tiempo = 0;
        }
    }

    private void Update()
    {
        // Para que no se vuelva ejecutar LoadScene
        if (GameFinish) return;


        if (collisionDetected) {
            tiempo += Time.deltaTime;
            if (tiempo >= 2f) {
                GameFinish = true;
            }
        }

        if (GameFinish)
        {
            SceneManager.LoadScene("FIN");
        }
    }

    
}
