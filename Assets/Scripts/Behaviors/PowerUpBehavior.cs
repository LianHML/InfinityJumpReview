using System.Collections;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject[] platformCollider;

    private GameObject gameController;
    private GameObject player;

    public bool isPowered;
    public bool allowFly;
    public bool coinMultiplyer;

    public int scoreMultiplyer = 1;

    private Vector2 randomRange;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        player = GameObject.FindGameObjectWithTag("Player");
        randomRange = new Vector2(1, 3);
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
                    StartCoroutine(FlyingJump());
                }
                break;
            case 3:
                {
                    StartCoroutine(CoinMultiplyer());
                }
                break;
        }
    }

    public IEnumerator GhostJump()
    {
        Debug.Log("Powerup 1");
        gameController.GetComponent<PlatformBehavior>().ToggleCollider();
        isPowered = true;

        yield return new WaitForSeconds(10f);

        gameController.GetComponent<PlatformBehavior>().ToggleCollider();
        StartCoroutine(TurnPoweredOff());
    }

    public IEnumerator FlyingJump()
    {
        Debug.Log("Powerup 2");
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        isPowered = true;
        allowFly = true;

        yield return new WaitForSeconds(30f);

        player.GetComponent<Rigidbody2D>().gravityScale = 2f;
        allowFly = false;
        StartCoroutine(TurnPoweredOff());
    }

    public IEnumerator CoinMultiplyer()
    {
        Debug.Log("Powerup 3");
        isPowered = true;
        coinMultiplyer = true;
        scoreMultiplyer = 4;

        yield return new WaitForSeconds(30);

        scoreMultiplyer = 1;
        coinMultiplyer = false;
        StartCoroutine(TurnPoweredOff());
    }

    private IEnumerator TurnPoweredOff()
    {
        yield return new WaitForSeconds(60);
        isPowered = false;
    }

    //CoinMagnect() foi desativado pois não é compativel com o InfinityPowerUpGenerator ainda

    //public IEnumerator CoinMagnect()
    //{
    //    Debug.Log("Powerup 3");
    //    coin.GetComponent<CoinBehavior>().SetTargetPosition(player.GetComponent<Rigidbody2D>().transform.position);

    //    Debug.Log("Player Are Magnect");
    //    isMagnect = true;

    //    yield return new WaitForSeconds(30f);

    //    Debug.Log("Player Are not Magnect anymore");
    //    isMagnect = false;
    //}
}
