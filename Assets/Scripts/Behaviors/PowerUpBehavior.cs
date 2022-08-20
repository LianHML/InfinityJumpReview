using System.Collections;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject[] platformCollider;

    private GameObject gameController;
    private GameObject coin;
    private GameObject player;

    public bool isPowered;

    private Vector2 randomRange;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        coin = GameObject.FindGameObjectWithTag("Bonus");
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
                    StartCoroutine(FlyingJump());
                }
                break;
            case 2:
                {
                    StartCoroutine(FlyingJump());
                    //FlyingJump();
                }
                break;
            case 3:
                {
                    StartCoroutine(FlyingJump());
                    //CoinMagnect();
                }
                break;
        }
    }

    public IEnumerator GhostJump()
    {
        Debug.Log("Vou ativar o ghost");
        gameController.GetComponent<PlatformBehavior>().ToggleCollider();
        isPowered = true;

        yield return new WaitForSeconds(10f);

        Debug.Log("Vou desativar o ghost");
        gameController.GetComponent<PlatformBehavior>().ToggleCollider();
        isPowered = false;
    }

    public IEnumerator FlyingJump()
    {
        Debug.Log("Powerup 2");
        player.GetComponent<Rigidbody2D>().gravityScale = 0;
        isPowered = true;

        yield return new WaitForSeconds(30f);

        player.GetComponent<Rigidbody2D>().gravityScale = 2;
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
