using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    // Variable para acceder desde unity 
    // Exite en memoria pero no tiene valor
    public static GameObject miObjeto;

    // vamos a llamar a ese objecto
    // NOTA Tener en cuenta cuando es creado el objeto para que este sea representado
    private void Awake()
    {
         // Inicializar con una referencia
        // miObjeto = this.gameObject;

    }

    void Start()
    {
        // Inicializar con una referencia
        miObjeto = this.gameObject;
    }
    void Update()
    {
        
    }
}
