using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();

        rb.AddForce(Vector2.up * 500);

    }

    // Update is called once per frame
    void Update()
    {
        if(!inPlay) // ! jest użyty jako skrót
        {
            transform.position = paddle.position;

        }
        
    }

    //pilka a solna granica

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("bottom"))
        {
            Debug.Log("Ball hit the bottom of the screen");
        }
    }



}
