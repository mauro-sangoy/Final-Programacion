using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{

    [SerializeField] private float speed = 3f;

    private Rigidbody2D playerRB;
    private Vector2 movInput;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        movInput = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + movInput * speed * Time.fixedDeltaTime);
    }
}
