using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewardsForce;
    float drag = 1f;
    float time = 0f;

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= 5f && drag > .5f)
        {
            time = time % 5f;
            drag-=.05f;
        }

        rb.AddForce(0, forwardForce * Time.deltaTime, 0);
        rb.drag = drag;

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewardsForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewardsForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
