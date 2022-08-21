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
            float directionX = Input.GetAxis("Horizontal") * Time.deltaTime;
            player.transform.Translate(directionX * speed, 0f, 0f);
        }

        if (Input.GetAxis("Vertical") != 0 && powerUps.GetComponent<PowerUpBehavior>().allowFly == true)
        {
            float directionY = Input.GetAxis("Vertical") * Time.deltaTime;
            player.transform.Translate(0f, directionY * speed, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform") && powerUps.GetComponent<PowerUpBehavior>().allowFly == false)
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, jumpForce);
        }
        if (collision.CompareTag("Bonus"))
        {
            gameController.GetComponent<ScoreChecker>().ScoreUpdate();
            gameController.GetComponent<MenuController>().ShowScore();
            collision.gameObject.SetActive(false); 
        }
        if (collision.CompareTag("PowerUp"))
        {
            powerUps.GetComponent<PowerUpBehavior>().RandomPowerUpSelector();
            collision.gameObject.SetActive(false); 
        }
    }
}
