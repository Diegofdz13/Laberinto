using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorDisparador : MonoBehaviour
{

    [SerializeField] Camera laCamaraQueQuieroUtilizar;

    Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    RaycastHit hit;
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {

            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out hit, 0.5f))
            {
                if (hit.collider.CompareTag("Boton"))
                {
                    hit.collider.GetComponent<Boton>().Pulsar();
                }
            }
            Debug.Log(Mouse.current.position.ReadValue());
            Debug.DrawRay(ray.origin, ray.direction * 0.5f, Color.red, 0.1f);
        }
    }
}
