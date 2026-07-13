using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        // Imprimer en panttala el nombre del objeto
        Debug.Log(Componente1.miObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
