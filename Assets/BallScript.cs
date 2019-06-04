using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();

        rb.AddForce(Vector2.up * 500);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
