using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private float moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         moveInput = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(moveInput * moveSpeed, rb.velocity.y, 0f);
    }
}
