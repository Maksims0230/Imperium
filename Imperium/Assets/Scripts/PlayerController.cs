using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.0f;
    public Rigidbody2D rb;
    private Vector2 _moveVelocity;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _moveVelocity = moveInput * speed;
    }

    private void FixedUpdate() {
        rb.MovePosition(rb.position + _moveVelocity * Time.fixedDeltaTime);
        float SRes = Vector2.Dot(rb.transform.right, _moveVelocity);
        rb.MoveRotation(rb.rotation - SRes);
    }
}
