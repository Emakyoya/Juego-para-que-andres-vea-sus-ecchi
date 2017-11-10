using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PointsMaster : MonoBehaviour {

    public float velocity = 2f;
    //public Text pointsText;
    

    private Rigidbody2D rb2d;
    



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void MovementPoint()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.left * velocity;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
        else
        if (collision.gameObject.tag == "DestroyerP")
        {
            Destroy(gameObject);
        }
    }



}
