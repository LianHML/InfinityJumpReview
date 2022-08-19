using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq ;

public class InfinityScroll : MonoBehaviour
{
    private GameObject[] platform;

    private GameObject gameController;

    private float width = 6f;

    private Vector2 speed;

    private Vector2 randomWidth;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");

        platform = GameObject.FindGameObjectsWithTag("Platform");

        speed = new Vector2(0, -2);

        randomWidth = new Vector2(-5.5f, 5.5f);
    }

    void Update()
    {
        InstantiatePlatform();
    }

    void InstantiatePlatform()
    {
        foreach (GameObject platformScroll in platform)
        {
            platformScroll.transform.Translate(speed * Time.deltaTime);

            if (platformScroll.transform.position.y < width * -1)
            {
                platformScroll.transform.Translate(new Vector2(0, width * 2));
                RandomPlatformPosition(platformScroll);
            }
        }
        gameController.GetComponent<ScoreChecker>().DistanceInGame();
    }

    private void RandomPlatformPosition(GameObject platform)
    {
        float randomValue = Random.Range(randomWidth.x, randomWidth.y);
        platform.transform.position = new Vector2(randomValue, platform.transform.position.y);
    }
}
