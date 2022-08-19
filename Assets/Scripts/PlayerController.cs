using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject player;
    private GameObject scoreChecker;
    private float speed = 6;
    private float jumpForce = 12;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreChecker = GameObject.FindGameObjectWithTag("GameController");
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float direction = Input.GetAxis("Horizontal") * Time.deltaTime;
            player.transform.Translate(direction * speed, 0f, 0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, jumpForce);
        }
        if (collision.CompareTag("Bonus"))
        {
            scoreChecker.GetComponent<ScoreChecker>().ScoreUpdate();
            scoreChecker.GetComponent<MenuController>().ShowScore();
            collision.gameObject.SetActive(false);
        }
    }
}
