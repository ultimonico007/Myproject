using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class muerte : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            controler controlador = FindObjectOfType<controler>();
            if (controlador != null )
            {
                controlador.Gameover();
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("No se encontró el script 'controler' en la escena.");
            }
           

        }
    }
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
