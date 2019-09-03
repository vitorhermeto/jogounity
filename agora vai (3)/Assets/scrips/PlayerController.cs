using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float pulo;
    Rigidboby2D rd;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
          rb.AddForce(new Vector2(0,pulo));
      }  
    }
}
