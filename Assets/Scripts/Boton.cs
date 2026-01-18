using UnityEngine;

public class Boton : MonoBehaviour
{
    public Puerta puerta;
    public ParticleSystem particulas;

    public void Pulsar()
    {
        Debug.Log("Boton se activa");

        particulas.Play();
        

        puerta.AbrirPuerta();
    }
}
