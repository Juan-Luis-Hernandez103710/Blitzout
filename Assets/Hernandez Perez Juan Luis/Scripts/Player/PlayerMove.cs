using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationSpeed = 5f;

    InputController _inputController = null;

    private void Awake()
    {
        _inputController = GetComponent<InputController>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 input = _inputController.MoveInput();

        transform.position += transform.forward * input.y * speed * Time.deltaTime;

        transform.Rotate(Vector3.up * input.x * rotationSpeed * Time.deltaTime);
    }
}
