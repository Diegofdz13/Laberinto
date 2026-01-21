// Motores de Videojuegos - Actividad 1 - Diego Fernández Cachinero
using UnityEngine;

public class Puerta : MonoBehaviour
{
    // Vector que indica cuanto se mueve la puerta y en que dirección
    public Vector3 desplazamiento = new Vector3(0, 3, 0);
    private Vector3 posicionInicial;
    // Indica si la puerta está abierta o cerrada
    private bool abierta = false;

    void Start()
    {
        // Guarda la posición inicial de la puerta
        posicionInicial = transform.position;
    }

    public void AbrirPuerta()
    {
        // Se llama desde el script Boton y desplaza la puerta
        if (abierta) return;

        transform.position = posicionInicial + desplazamiento;
        abierta = true;
    }

}   