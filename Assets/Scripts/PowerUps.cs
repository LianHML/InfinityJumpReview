using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField]
    GameObject[] platformCollider;
    GameObject gameController;
    private bool isPowerUp = false;
    private Vector2 randomRange;

    IEnumerator Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        randomRange = new Vector2(1, 3);
        while (true)
        {
            yield return new WaitForSeconds(5f);
            SetPowerTrue();
        }
    }

    void Update()
    {
    }

    public void SetPowerTrue()
    {
        Debug.Log(Time.time);
        Debug.Log("Powerup true");
        isPowerUp = true;
    }
    
    public void RandomPowerUpSelector()
    {
        if (isPowerUp == true)
        {
            int random = (int)Random.Range(randomRange.x, randomRange.y);
            switch (random)
            {
                case 1: 
                    GhostJump(); 
                    break;
                case 2: 
                    FlyingJump(); 
                    break;
                case 3: 
                    CoinMagnect(); 
                    break;
            }
        }
    }

    public void GhostJump()
    {
        Debug.Log("Powerup 1");
        foreach (var PlatformCollider in platformCollider)
        {
            PlatformCollider.SetActive(false);
        }

        StartCoroutine(WaitThirtenSeconds());

        foreach (var PlatformCollider in platformCollider)
        {
            PlatformCollider.SetActive(true);
        }
        Debug.Log("Estou definindo powerup como false");
        isPowerUp = false;
    }

    public void FlyingJump()
    {

        Debug.Log("Powerup 2");
        Debug.Log("Estou definindo powerup como false");
        isPowerUp = false;
    }

    public void CoinMagnect()
    {
        Debug.Log("Powerup 3");
        Debug.Log("Estou definindo powerup como false");
        isPowerUp = false;
    }

    public IEnumerator WaitThirtenSeconds()
    {
        yield return new WaitForSeconds(30f);
    }

    public IEnumerator WaitAMinute()
    {
        yield return new WaitForSeconds(60f);
    }
}
