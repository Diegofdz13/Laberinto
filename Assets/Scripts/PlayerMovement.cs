using System;
using UnityEngine;
using UnityEngine.InputSystem;


// Aqui mi rey, esta habilitada la forma chunga de hacer esto, pero que da más felxibildad que el player input
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;


    [SerializeField] InputActionReference move;
    [SerializeField] InputActionReference shoot;
    [SerializeField] InputActionReference jump;

    Vector2 rawMove = Vector2.zero;

    private void OnEnable()
    {
        move.action.Enable();
        shoot.action.Enable();
        jump.action.Enable();

        jump.action.started += __OnJump;

        move.action.started += __OnMove;
        move.action.performed += __OnMove;
        move.action.canceled += __OnMove;
    }

    private void OnDisable()
    {
        move.action.started -= __OnMove;
        move.action.performed -= __OnMove;
        move.action.canceled -= __OnMove;

        jump.action.started -= __OnJump;

        move.action.Disable();
        shoot.action.Disable();
        jump.action.Disable();
    }

    float verticalVelocity = 0f;
    private void Update()
    {
        if (mustJump)
            mustJump = false;
        verticalVelocity = 10f; //jumpSpeed

        Vector3 moveToAplly = new Vector3(rawMove.x, 0f, rawMove.y) * speed * Time.deltaTime;
        transform.Translate(moveToAplly);
    }

    void __OnMove(InputAction.CallbackContext ctx)
    {
        rawMove = ctx.ReadValue<Vector2>();
        // Esto nos devuelve el nombre del dispositivo para saber que botoón se esta pulsando
        Debug.Log(ctx.control.device);
        Debug.Log(rawMove);
    }

    bool mustJump = false;
    void __OnJump(InputAction.CallbackContext ctx)
    {
        Debug.Log(ctx.control.device);
        mustJump = ctx.ReadValueAsButton();
    }

    // Esto creo que es más sencillo que lo de arriba y sirve para ma o meno lo mismos
    // Este es más limitante a nivel de controles
    //public void OnMove(InputValue value)
    //{
    //    rawMove = value.Get<Vector2>();
    //    Debug.Log(rawMove);
    //}

    //void OnJump()
    //{
    //    mustJump = true;
    //    Debug.Log("MustJump!");
    //}

}
