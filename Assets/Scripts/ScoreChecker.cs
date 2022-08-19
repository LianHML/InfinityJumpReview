using UnityEngine;
public class ScoreChecker : MonoBehaviour
{
    [SerializeField] 
    private FloatSO scoreSO;

    [SerializeField]
    private FloatSO totalScoreSO;

    [SerializeField]
    private FloatSO distanceSO;

    [SerializeField]
    private FloatSO totalDistanceSO;

    void Start()
    {

    }

    public void ScoreUpdate()
    {
        scoreSO.Value++;
        totalScoreSO.Value++;
    }
    public void ScoreReset()
    {
        scoreSO.Value = 0;
    }
    public void DistanceInGame()
    {
        distanceSO.Value++;
        totalDistanceSO.Value++;
    }
    public void DistanceReset()
    {
        distanceSO.Value = 0;
    }
}
