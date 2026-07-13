using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour

{

    // Cambiar el nombre al objeto
    void Awake()
    {
        //Componente1.miObjeto.name = "nuevoNombreDeMiObjeto";    
    }

    // Start is called before the first frame update
    void Start()
    {
        Componente1.miObjeto.name = "nuevoNombreDeMiObjeto";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
