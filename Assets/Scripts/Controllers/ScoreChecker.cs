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

    private GameObject powerUp;

    void Start()
    {
        powerUp = GameObject.FindGameObjectWithTag("PowerUpMaster");
        InvokeRepeating("DistanceInGame", 1f, 1f);
    }

    public void ScoreUpdate()
    {
        if (powerUp.GetComponent<PowerUpBehavior>().coinMultiplyer)
        {
            scoreSO.Value += 1 * powerUp.GetComponent<PowerUpBehavior>().scoreMultiplyer;
            totalScoreSO.Value += 1 * powerUp.GetComponent<PowerUpBehavior>().scoreMultiplyer;
        }
        else
        {
            scoreSO.Value++;
            totalScoreSO.Value++;
        }
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
