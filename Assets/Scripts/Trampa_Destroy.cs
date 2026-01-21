// Motores de Videojuegos - Actividad 1 - Diego Fernández Cachinero
using UnityEngine;

// Código que hace que las trampas devuelvan al jugador al incio al tocarlo
public class Trampa_Destroy : MonoBehaviour
{
    // Alamcena el punto de inicio al que se envia el juagdor
    public Transform puntoInicio;

    private void OnTriggerStay(Collider other)
    {
        // Comprueba si los objetos dentro del trigger tienen la etiqueta Player
        if (other.CompareTag("Player"))
        {
            // Obtiene el CharacterController del jugador 
            CharacterController cc = other.GetComponent<CharacterController>();

            // Si obtiene el CharacterController, se desactiva para poder desplazar al jugador
            if (cc != null)
            {
                cc.enabled = false;

                other.transform.position = puntoInicio.position;

                cc.enabled = true;
            }

            Debug.Log("Jugador eliminado");
        }
    }
}
