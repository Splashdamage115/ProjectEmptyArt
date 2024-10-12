using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 move;
    [SerializeField]
    private float speed;

    private bool isFacingRight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue action)
    {
        move = action.Get<Vector2>();

        if (move.x > 0 && isFacingRight)
            Flip();
        else if (move.x < 0 && !isFacingRight)
            Flip();
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

        void FixedUpdate()
    {
        rb.position += (move * speed * Time.fixedDeltaTime);
    }
}
