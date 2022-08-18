using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private GameObject player;
    private GameObject gameController;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //gameController = GameObject.FindGameObjectWithTag("GameController");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //gameController.GetComponent<MenuController>().GameOver();
            player.SetActive(false);
        }
    }
}
