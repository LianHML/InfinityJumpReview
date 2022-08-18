using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject resume;
    [SerializeField] private GameObject player;
    void Start()
    {
        Time.timeScale = 0f;
    }
    private void Update()
    {
        if (!player.activeSelf)GameOver();
    }

    public void RestartScene()
    {
        gameObject.GetComponent<ScoreChecker>().ScoreReset();
        SceneManager.LoadScene("TestScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        startMenu.SetActive(false);
    }

    public void GameOver()
    {
        gameObject.GetComponent<ScoreChecker>().FinalScoreSet();
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        resume.SetActive(true);
        pause.SetActive(false);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        resume.SetActive(false);
        pause.SetActive(true);
    }
}
