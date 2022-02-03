using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cube : MonoBehaviour
{

    public GameObject player;

    PlayerControls controls;

    Vector2 move;

    void Awake() {

        controls = new PlayerControls();

        controls.Gameplay.Jump.performed += ctx => Jump();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    }

    void Jump() {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 400, 0, ForceMode.Acceleration);
    }

    void Update() {



        Vector3 m = new Vector3(move.x, 0, move.y) * 10f * Time.deltaTime;
        transform.Translate(m, Space.World);

    }

    void OnEnable() {

        controls.Gameplay.Enable();
    }

    void OnDisable() {
        controls.Gameplay.Disable();
    }
}
