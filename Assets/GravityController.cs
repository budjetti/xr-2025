using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public bool freeze = false;
    [SerializeField] private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        // something something grabbing
        rb.isKinematic = freeze;
    }
}
