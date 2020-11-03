using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {
  public float speed = .1f;
  public float rotationSpeed = .1f;
  public string HoriAxis;
  public string VertiAxis;
  private Transform trans;
  // Start is called before the first frame update
  void Start () {
    trans = GetComponent<Transform>();
  }

  // Update is called once per frame
  void Update () {
        float translation = Input.GetAxis(VertiAxis) * speed * Time.deltaTime;
        float rotation = Input.GetAxis(HoriAxis) * rotationSpeed * Time.deltaTime;
        trans.Translate(0, 0, translation);
        trans.Rotate(0, rotation, 0);
  }
}