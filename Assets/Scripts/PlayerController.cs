using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : NetworkBehaviour {

    PlayerMotor playerMotor;

    private void Start() {
        playerMotor = GetComponent<PlayerMotor>();
    }

    private void FixedUpdate() {
        if (!isLocalPlayer)
            return;
        Vector3 inputDirection = GetInput();
        playerMotor.MovePlayer(inputDirection);
    }

    Vector3 GetInput() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        return new Vector3(h, 0, v);
    }

}
