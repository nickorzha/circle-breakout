using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector3 lastvelocity;
    public float minvelocity = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector2(100f, 100f));
    }

    // Update is called once per frame
    void Update()
    {
        lastvelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log("Bounce");
        var speed = lastvelocity.magnitude;
        var direction = Vector3.Reflect(lastvelocity.normalized, coll.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, minvelocity);
    }
}
