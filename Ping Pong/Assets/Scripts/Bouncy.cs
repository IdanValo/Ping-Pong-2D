using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceStrength = 0.8f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.ballRB.AddForce(-normal * bounceStrength, ForceMode2D.Impulse);
        }
    }
}
