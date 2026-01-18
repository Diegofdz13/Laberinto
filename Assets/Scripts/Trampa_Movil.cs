using UnityEngine;

public class Trampa_Movil : MonoBehaviour
{
    public float distancia = 5f;
    public float velocidad = 2f;
    public Vector3 direccion = Vector3.right;

    private Vector3 posicionInicial;
    private Rigidbody rb;

    void Start()
    {
        posicionInicial = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float desplazamiento = Mathf.PingPong(Time.time * velocidad, distancia);
        Vector3 nuevaPos = posicionInicial + direccion.normalized * desplazamiento;
        rb.MovePosition(nuevaPos);
    }
}
