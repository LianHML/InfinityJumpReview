using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject player;

    [SerializeField]
    private GameObject gameController;

    [SerializeField]
    private GameObject powerUps;

    private const float speed = 6;

    private const float jumpForce = 12; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameController = GameObject.FindGameObjectWithTag("GameController");
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
            powerUps.GetComponent<PowerUps>().RandomPowerUpSelector();
            gameController.GetComponent<ScoreChecker>().ScoreUpdate();
            gameController.GetComponent<MenuController>().ShowScore();
            collision.gameObject.SetActive(false); 
        }
    }
}
