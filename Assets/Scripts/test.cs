using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        print("Funcion antigua para mandar un mensaje: print ya que es herada de monoBehavior");

        Debug.Log("Mensaje para ir validando la programacion");

        Debug.LogError("Mensaje de Error en la aplicacion");

        Debug.LogWarning("Dejar un mensaje de advertencia");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
