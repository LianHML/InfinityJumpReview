using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreChecker : MonoBehaviour
{
    //[SerializeField] private GameObject scoreCoin;
    private int score;
    [SerializeField] private Text showScore;
    [SerializeField] private FloatSO scoreSO;
    [SerializeField] private Text finalScore;
    private float scoreLegado;
    void Start()
    {
        //scoreCoin = GameObject.FindGameObjectWithTag("Score");
    }

    public void ScoreUpdate()
    {
        scoreSO.Value++;
        showScore.text = "Score: " + scoreSO.Value;
        //scoreCoin.SetActive(false);
        //StartCoroutine(CoinGenerator());
    }
    public void FinalScoreSet()
    {
        finalScore.text = "Your final Score is: " + scoreSO.Value;
    }
    public void ScoreReset()
    {
        scoreLegado = scoreSO.Value;
        scoreSO.Value = 0;
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
