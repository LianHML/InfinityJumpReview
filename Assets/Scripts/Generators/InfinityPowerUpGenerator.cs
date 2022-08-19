using UnityEngine;

public class InfinityPowerUpGenerator : MonoBehaviour
{
    private GameObject[] powerup;

    private float width = 6f;

    private Vector2 speed;

    private Vector2 randomWidth;

    void Start()
    {
        powerup = GameObject.FindGameObjectsWithTag("Powerup");

        speed = new Vector2(0, -2);

        randomWidth = new Vector2(-5.5f, 5.5f);
    }

    void Update()
    {
        InstantiatePowerUp();
    }

    private void InstantiatePowerUp()
    {
        foreach (GameObject powerUpGen in powerup)
        {
            powerUpGen.transform.Translate(speed * Time.deltaTime);

            if (powerUpGen.transform.position.y < width * -1)
            {
                powerUpGen.transform.Translate(new Vector2(0, width * 2));
                RandomPowerUpPosition(powerUpGen);

                if (!powerUpGen.activeSelf)
                {
                    powerUpGen.SetActive(true);
                }
            }
        }
    }

    private void RandomPowerUpPosition(GameObject powerUpGen)
    {
        float randomValue = Random.Range(randomWidth.x, randomWidth.y);
        powerUpGen.transform.position = new Vector2(randomValue, powerUpGen.transform.position.y);
    }
}
