using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMetodosVariable : MonoBehaviour
{

    // Creando una variable sin inicializar
    int x;

    void Start()
    {
        // Asignando un valor en el metodo start que solo se ejecuta una vez
        x = 0;
        Debug.Log("Este es el valor que se ejecuta en el metodo START " + x);
    }

    // Update is called once per frame
    void Update()
    {
        // Agrendo un valor a la variable en UPDATE que se ejecuta cada frame imprimiendo en warning
        x += 1;
        Debug.LogWarning("Este es el valor que se ejecuta en el metodo UPDATE " + x);
    }
}
