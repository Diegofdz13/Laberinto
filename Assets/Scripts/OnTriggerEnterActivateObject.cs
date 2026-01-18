using UnityEngine;

public class OnTriggerEnterActivateObject : MonoBehaviour
{
    [SerializeField] private GameObject toActivate;
    private void OnTriggerEnter(Collider other)
    {
        toActivate.SetActive(true);
    }
}
