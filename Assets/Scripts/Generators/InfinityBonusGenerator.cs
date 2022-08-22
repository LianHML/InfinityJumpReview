using UnityEngine;

public class InfinityBonusGenerator : MonoBehaviour
{
    private GameObject[] bonus;

    private float width;

    private float height;

    private Vector2 speed;

    private Vector2 randomHeigth;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        bonus = GameObject.FindGameObjectsWithTag("Bonus");

        speed = new Vector2(0, -2);

        randomHeigth = new Vector2(height * -1, height);

        width = mainCamera.pixelWidth / 100f;

        height = mainCamera.pixelHeight / 100f;

    }

    void Update()
    {
        InstantiateBonus();
    }

    void InstantiateBonus()
    {
        foreach (GameObject bonusGen in bonus)
        {
            bonusGen.transform.Translate(speed * Time.deltaTime);

            if (bonusGen.transform.position.y < height * -1)
            {
                bonusGen.transform.Translate(new Vector2(0, width * 2));
                RandomBonusPosition(bonusGen);

                if (!bonusGen.activeSelf)
                {
                    bonusGen.SetActive(true);
                }
            }
        }
    }

    private void RandomBonusPosition(GameObject bonusGen)
    {
        float randomValue = Random.Range(randomHeigth.x, randomHeigth.y);
        bonusGen.transform.position = new Vector2(randomValue, bonusGen.transform.position.y);
    }
}
