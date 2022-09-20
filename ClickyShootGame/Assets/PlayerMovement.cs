using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Vector2 velocity;

    private float vertical;
    private float horizontal;
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        velocity = new Vector2(horizontal, vertical);

        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        playerRB.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
