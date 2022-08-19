using UnityEngine;
public class ScoreChecker : MonoBehaviour
{
    [SerializeField] 
    private FloatSO scoreSO;

    [SerializeField]
    private FloatSO totalScore;

    void Start()
    {

    }

    public void ScoreUpdate()
    {
        scoreSO.Value++;
        totalScore.Value++;
    }
    public void ScoreReset()
    {
        scoreSO.Value = 0;
    }
}
