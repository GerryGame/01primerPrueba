using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboConCodigo : MonoBehaviour
{

    GameObject objToSpaw;
        Vector3[] vertices =
        {
            new Vector3 (0, 0, 0), //Vertice0
            new Vector3 (1, 0, 0), //Vertice1
            new Vector3 (1, 1, 0), //Vertice2
            new Vector3 (0, 1, 0), //Vertice3
            new Vector3 (0, 1, 1), //Vertice4
            new Vector3 (1, 1, 1), //Vertice5
            new Vector3 (1, 0, 1), //Vertice6
            new Vector3 (0, 0, 1), //Vertice7
        };

        int[] triangulos =
        {
            0, 2, 1, // Cara 1
            0, 3, 2,
            2, 3, 4, // Cara 2
            2, 4, 5,
            1, 2, 5, // Cara 3
            1, 5, 6,
            0, 7, 4, // Cara 4
            0, 4, 3,
            5, 4, 7, // Cara 5
            5, 7, 6,
            0, 6, 7, // Cara 6
            0, 1, 6,
        };

    // Start is called before the first frame update
    void Start()
    {

        // Creacion de un curo
        objToSpaw = new GameObject("CuboConCodigo");
        // agregando un componente
        objToSpaw.AddComponent<MeshFilter>();
        // hacer la referencia
        var meshFilter = objToSpaw.GetComponent<MeshFilter>().mesh;
        // Modificar los datos 
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        // Recalcular las normales
        meshFilter.RecalculateNormals();

        // Agrendo el colider
        objToSpaw.AddComponent<BoxCollider>();
        var boxColider = objToSpaw.GetComponent<BoxCollider>();
        //Centro del colider
        boxColider.center = new Vector3(0.5f, 0.5f, 0.5f);

        // Agregar el mesh render
        objToSpaw.AddComponent<MeshRenderer>();
        // Referencia al material
        var meshRender = objToSpaw.GetComponent<MeshRenderer>().material;
        meshRender.color = Color.white;

        // posicion
        objToSpaw.transform.position = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
