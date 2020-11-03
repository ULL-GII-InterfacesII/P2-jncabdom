using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBallColors : MonoBehaviour {
    public float thrust = 1.0f;
    private bool changeColor = false;
    private bool pushBack = false;
    private Collision otherCollider;
    void OnCollisionEnter (Collision col) {
        if ((col.gameObject.tag == "SphereA") || (col.gameObject.tag == "Sphere")) {
            otherCollider = col;
            changeColor = true;
        }
        if (col.gameObject.tag == "SphereA") {
            otherCollider = col;
            pushBack = true;
        }
    }
    void FixedUpdate () {
        if (changeColor) {
            Renderer rd = otherCollider.gameObject.GetComponent<Renderer> ();
            rd.material.color = Color.green;
            changeColor = false;
        }
        if (pushBack) {
            Rigidbody rb = otherCollider.gameObject.GetComponent<Rigidbody> ();
            Vector3 dir = (transform.position - otherCollider.gameObject.transform.position).normalized;
            rb.isKinematic = true;
            if (Input.GetKey (KeyCode.Space)) {
                rb.isKinematic = false;
                rb.AddForce (-dir * thrust);
            }
            pushBack = false;
        }
    }
}

