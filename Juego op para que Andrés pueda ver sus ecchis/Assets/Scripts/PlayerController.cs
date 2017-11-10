using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;
    private bool doubleJump;
    private AudioSource audioPlayer;

    public AudioClip jumpclip;
    public AudioClip Deadclip;

    public GameObject CamvasGame;
    public bool grounded;
    public float jumpPower = 6.5f;
    public PointsManager puntos;
    GameObject point;



    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        audioPlayer = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Grounded", grounded);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                jump = true;
                doubleJump = true;

                audioPlayer.clip = jumpclip;
                audioPlayer.Play();
            }
            else
            if(doubleJump)
            {
                jump = true;
                doubleJump = false;

                audioPlayer.clip = jumpclip;
                audioPlayer.Play();
            }
            
        }
    }

    void FixedUpdate()
    {
        if (jump)
        {
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
    
    }
    void OnCollisionStay2D(Collision2D col)
    {
        grounded = true;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        grounded = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        point = GameObject.Find("Point01");
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

            

        }
        else
        if (col.gameObject.tag == "Point")
        {
            Destroy(point);
            puntos.IncreasePoints();
        }
    }

    
}
