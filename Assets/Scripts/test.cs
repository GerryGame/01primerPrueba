using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       /* print("Funcion antigua para mandar un mensaje: print ya que es herada de monoBehavior");

        Debug.Log("Mensaje para ir validando la programacion");

        Debug.LogError("Mensaje de Error en la aplicacion");

        Debug.LogWarning("Dejar un mensaje de advertencia"); */

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde fixedUpdate cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate ");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto a sido habiltado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto a sido deshabiltado");
    }

}


