// Motores de Videojuegos - Actividad 1 - Diego Fernández Cachinero
using UnityEngine;
// Código que activa un GameObject cuando otro objeto entra en el trigger
public class OnTriggerEnterActivateObject : MonoBehaviour
{
    [SerializeField] private GameObject toActivate;
    private void OnTriggerEnter(Collider other)
    {
        toActivate.SetActive(true);
    }
}
