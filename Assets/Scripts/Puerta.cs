using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Vector3 desplazamiento = new Vector3(0, 3, 0);
    private Vector3 posicionInicial;
    private bool abierta = false;

    void Start()
    {
        posicionInicial = transform.position;
    }

    public void AbrirPuerta()
    {
        if (abierta) return;

        transform.position = posicionInicial + desplazamiento;
        abierta = true;
    }

}   