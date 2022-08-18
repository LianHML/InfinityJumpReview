using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreChecker : MonoBehaviour
{
    [SerializeField] private GameObject scoreCoin;
    private int score;
    [SerializeField] private Text showScore;
    void Start()
    {
        //scoreCoin = GameObject.FindGameObjectWithTag("Score");
    }

    public void ScoreUpdate()
    {
        score++;
        showScore.text = "Score: " + score;
        scoreCoin.SetActive(false);
        //StartCoroutine(CoinGenerator());
    }

    //IEnumerator CoinGenerator()
    //{
    //    yield return new WaitForSeconds(5);
    //    scoreCoin.SetActive(true);
    //}


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("CoinChecker"))
    //    {
    //        if (!scoreCoin.activeSelf)
    //        {
    //            scoreCoin.SetActive(true);
    //        }
    //    }
    //}
}
