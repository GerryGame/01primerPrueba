using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodosUnity : MonoBehaviour
{
    //Funcion cuando se crea el gameObject
    void Akake()
    {

    }

    // Cada que se active o se desactive un gameObject 
    // Se usa para activar el gameObject
    private void OnEnable()
    {
        
    }

    // void Reset -> No se utiliza comunmente
    private void Reset()
    {
        
    }

    // Inicializa cosas del juego 
    // CONDICION DE CARRERA -> Dos ejecuciones al mismo tiempo que se encuentran y no se puede realizar una por 
    // fue realizada por otra 
    void Start()
    {
        
    }

    // Motor para fisica y se ejecuta cada 50 frames
    // dentro de ellas existen las funciones de fisica y animacion
    // state machine update, onStateMachineEnter/Exit, ProcessGraph, Fire animation events, StateMachibeBehevior callbacks, OnAnimatorMove
    // ProcessAnimation, onAnimationIk, WriteTraNSFORM, WriteProperties
    private void FixedUpdate()
    {
        
    }

    // Permire ejecutrar corrutinas yield 
    // estas existen aqui onTriggersXXX, OnColisionXXX, wield WaitForFixedUpdate, onMouseXXX

    // Sistema clasico de eventos Input
    private void OnMouseDown()
    {
        
    }

    // Se ejecuta en cada uno de los frame del juego
    void Update()
    {
        
    }

    // Funciones para corrutinas
    // yiel null, yiel WaitForSeconds, Yiel XXX, Yiel StartCouritine

    // Otras funciones de animacion 
    // State machine update, onStationMachineEnterExit, ProcessGraph, fire animation events, StateMachineBehevios callbacks, onAnimiationMove, ProcessAnimation, onAnimationIL, WriteTransform, WritePriperties


    // Esta ocurre al final del frame en la pantalla
    // Evita las condiciones de carrera
    private void LateUpdate()
    {
        
    }


    // Funciones de renderizado de unity
    // onPreCuli, OnWillRenderObject, OnBecameVisble, onBecameInvisible ,onPreRTender, OnRenderObject, OnPostRender OnRenderImage
    // para los gizmos onDrawGizmos


    // Interfaz grafica  primero es logica del juiego y despues la interfaz grafica
    private void OnGUI()
    {
        
    }

    // Esperar al final del frame 
    //yiel WaitForEndOfFrame

    // Generar una pausa en la aplicacion1
    private void OnApplicationPause(bool pause)
    {
        
    }

    // Cerrar la aplicacion que permite la liberacion de memoria
    private void OnApplicationQuit()
    {
        
    }

    // Se usa para desactivar el gameObject
    void onDisable()
    {
        
    }

    // Eliminar un elementro
    private void OnDestroy()
    {
        
    }
}
