using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour {
    public float threshold;
    public float scaleFactor;
    public float minScale;
    public float maxScale;
    private GameObject[] players;
    private GameObject[] spheres;

    void Start () {
        spheres = GameObject.FindGameObjectsWithTag ("SphereA");
        players = GameObject.FindGameObjectsWithTag ("Player");
    }

    // Update is called once per frame
    void FixedUpdate () {
        foreach (GameObject sphere in spheres) {
            if (Vector3.Distance (sphere.transform.position, transform.position) < threshold) { 
                if(Vector3.Distance(transform.localScale, Vector3.zero) < maxScale) 
                  transform.localScale += Vector3.one * Time.deltaTime * scaleFactor; 
            }
        }
        foreach (GameObject player in players) {
            if (Vector3.Distance (player.transform.position, transform.position) < threshold) {
                if(Vector3.Distance(transform.localScale, Vector3.zero) > minScale) 
                  transform.localScale -= Vector3.one * Time.deltaTime * scaleFactor; 
            }
        }
    }
}