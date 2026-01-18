using UnityEngine;

public class Trampa_Destroy : MonoBehaviour
{
    public Transform puntoInicio;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController cc = other.GetComponent<CharacterController>();

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
