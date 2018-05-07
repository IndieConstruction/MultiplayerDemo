 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour {

    Rigidbody _rigidbody;

    public float MovementSpeed = 100f;

    // Use this for initialization
    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
	}

    public void MovePlayer(Vector3 _movedirect) {
        Vector3 moveDirection = _movedirect * MovementSpeed * Time.deltaTime;
        _rigidbody.velocity = moveDirection;
    }

}
 