using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityBonusGenerator : MonoBehaviour
{
    private GameObject[] bonus;
    private float width = 6f;
    private Vector2 speed;
    private Vector2 randomWidth;

    void Start()
    {
        bonus = GameObject.FindGameObjectsWithTag("Bonus");

        speed = new Vector2(0, -2);

        randomWidth = new Vector2(-5.5f, 5.5f);
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

            if (bonusGen.transform.position.y < width * -1)
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
        float randomValue = Random.Range(randomWidth.x, randomWidth.y);
        bonusGen.transform.position = new Vector2(randomValue, bonusGen.transform.position.y);
    }
}
