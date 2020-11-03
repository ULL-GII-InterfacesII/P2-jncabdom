using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvadePlayer : MonoBehaviour {
    public Transform other;
    public float threshold;
    public float moveSpeed;

    // Update is called once per frame
    void FixedUpdate () {
        if (Vector3.Distance (other.position, transform.position) < threshold) {
            Vector3 dir = (transform.position - other.position).normalized;
            transform.position += dir * Time.deltaTime * moveSpeed;
        }
    }
}
