using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingHopefully : MonoBehaviour {

    public Rigidbody rb;
    public float ForceForward = 2000f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForceForward * Time.deltaTime);
    }
