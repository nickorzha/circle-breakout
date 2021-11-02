using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 50f;
    private float direction = 0f;
    private Vector3 point = new Vector3(0, 0, 0);
    private Vector3 axis = new Vector3(0, 0, 1);

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        if (direction > 0f)
        {
            transform.RotateAround(point, axis, Time.deltaTime * -speed);
        }
        else if(direction < 0f)
        {
            transform.RotateAround(point, axis, Time.deltaTime * speed);
        }
    }
}
