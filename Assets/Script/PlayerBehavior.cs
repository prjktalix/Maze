using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 3f;
    public float JumpVelocity = 1f;

    private bool isJumping;
    
    private bool grounded = false;

    //function for setting grounded value by the trigger volume script
    public bool IsGrounded
    {
        get { return grounded; }
        set { grounded = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isJumping |= Input.GetKeyDown(KeyCode.Space);
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0, vertical);
        rb.MovePosition(transform.position + move * Time.deltaTime * moveSpeed);
        if (isJumping && grounded == true) //added another conditional that the ball must be grounded
        {
            rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }

        isJumping = false;
    }

}