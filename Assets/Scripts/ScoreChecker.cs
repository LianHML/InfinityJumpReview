using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreChecker : MonoBehaviour
{
    [SerializeField] private FloatSO scoreSO;
    [SerializeField] private FloatSO totalScore;

    //[SerializeField] private Text showScore;
    //[SerializeField] private Text finalScore;
    //[SerializeField] private Text lastScore;
    //[SerializeField] private Text totalScore;
    void Start()
    {

    }

    public void ScoreUpdate()
    {
        scoreSO.Value++;
        totalScore.Value ++;
        //showScore.text = "Score: " + scoreSO.Value;
    }
    public void ScoreReset()
    {
        scoreSO.Value = 0;
    }

    //public void LastScoreSet()
    //{
    //    lastScore.text = "Last Score: " + scoreSO.Value;
    //    totalScore.text = "Total Score: " + totalScoreInGame;
    //}
}
