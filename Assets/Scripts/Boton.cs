// Motores de Videojuegos - Actividad 1 - Diego Fernández Cachinero
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Puerta puerta;
    public ParticleSystem particulas;

    // Ejecuta el metodo Pulsar() cuando es llamado en en script CursorDisparador
    // Activa las particulas asignadas y llama al metodo AbrirPuerta()
    public void Pulsar()
    {
        Debug.Log("Boton se activa");

        particulas.Play();
        

        puerta.AbrirPuerta();
    }
}
