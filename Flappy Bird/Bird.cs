using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

private Vector2 speed;

public class Bird : MonoBehavior
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    //Use serializeField to edit a variable from the inspector even if its private 
    [SerializeField]
    private float slapForce = 20f;
    private Vector2 speed;


    //Use this for intialization
    bool isDead;
    public GameObject ReplayButton;
    void OnCollisionEnter2D(Collision2D collision)
    {

        isDead = true;
        Vector2 vector2 = rb2d.velocity - Vector2.zero;
        //Change the isDead parameter of the animator to start the dead animation
        GetComponent<Animator>().SetBool("isDead", true);
        //GetComponent<Animator>()is a reference to the animator of the Bird
    }

    private object GetComponent<T>()
    {
        throw new NotImplementedException();

    }
    private object GetComponent<T>()
    {
        throw new NotImplementedException();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("A trigger collision is detected");
    }
    void Start()
    {
        Time.timeScale = 0;
        rb2d = (Rigidbody2D)GetComponent<Rigidbody2D>();
        NewMethod();
        //Go right
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        //Get a reference to the Rigidbody2D of the bird
#pragma warning disable CS8321 // Local function is declared but never used
        void OnTriggerExit2D(Collider2D col)
#pragma warning restore CS8321 // Local function is declared but never used
        {
            Debug.Log("The object left the trigger collision");
            if (col.gameObject.tag == "Player")
            {
#pragma warning disable CS0168 // Variable is declared but never used

            }
            transform.position += 2 * Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
#pragma warning restore CS0168 // Variable is declared but never used



        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
#pragma warning disable CS0642 // Possible mistaken empty statement
            bool isDead = false;
            if (!Input.GetMouseButtonDown(0) || isDead) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        }
    }
}