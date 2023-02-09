using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = 300f;
    public new Rigidbody2D ballRB { get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        ballRB = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        ballRB.velocity = Vector2.zero;
        ballRB.position = Vector2.zero;
    }

    public void BallStartForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                              : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        ballRB.AddForce(direction * ballSpeed);
    }
}
