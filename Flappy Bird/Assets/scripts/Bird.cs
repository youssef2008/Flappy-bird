using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    //Use serializeField to edit a variable from the inspector even if its private 
    [SerializeField]
    private float flapForce = 20f;
    [SerializeField]
    private float speed;
    bool isDead = false;

    public GameObject ReplayButton;

    int score = 0;
    public Text scoreText;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Score")
        {
            score++;

            Debug.Log(score);

            scoreText.text = score.ToString();
        }
    }

    void Start()
    {
        Time.timeScale = 0;

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        isDead = true;
        rb2d.velocity = Vector2.zero;
        //Change the isDead parameter of the animator to start the dead animation
        GetComponent<Animator>().SetBool("isDead", true);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            rb2d.velocity = Vector2.right * speed;
            rb2d.AddForce(Vector2.up * flapForce);
        }

    }
    public void UnFreeze()
    {
        Time.timeScale = 1;
        ReplayButton.SetActive(false);
    }

    
}



