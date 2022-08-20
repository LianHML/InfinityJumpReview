using System.Collections;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject[] platformCollider;
    private GameObject gameController;
    private Vector2 randomRange;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        randomRange = new Vector2(1, 3);
    }

    void Update()
    {
    }
    
    public void RandomPowerUpSelector()
    {
        int random = (int)Random.Range(randomRange.x, randomRange.y);
        switch (random)
        {
            case 1:
                {
                    StartCoroutine(GhostJump());
                }
                break;
            case 2:
                {
                    StartCoroutine(GhostJump());
                    //FlyingJump();
                }
                break;
            case 3:
                {
                    StartCoroutine(GhostJump());
                    //CoinMagnect();
                }
                break;
        }
    }

    public IEnumerator GhostJump()
    {
        Debug.Log("Vou ativar o ghost");
        gameController.GetComponent<PlatformBehavior>().ToggleCollider();

        yield return new WaitForSeconds(30f);

        Debug.Log("Vou desativar o ghost");
        gameController.GetComponent<PlatformBehavior>().ToggleCollider();
    }

    public void FlyingJump()
    {
        Debug.Log("Powerup 2");
    }

    public void CoinMagnect()
    {
        Debug.Log("Powerup 3");
    }

    public IEnumerator WaitAMinute()
    {
        yield return new WaitForSeconds(60f);
    }
}
