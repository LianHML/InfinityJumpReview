using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject resume;
    [SerializeField] private GameObject player;

    [SerializeField] private FloatSO scoreSO;
    [SerializeField] private FloatSO totalScoreSO;
    [SerializeField] private Text showScore;
    [SerializeField] private Text finalScore;
    [SerializeField] private Text lastScore;
    [SerializeField] private Text totalScore;
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
        SceneManager.LoadScene("TestScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        gameObject.GetComponent<ScoreChecker>().ScoreReset();
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        finalScore.text = "Your final Score is: " + scoreSO.Value;
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }
    public void ShowScore()
    {
        showScore.text = "Score: " + scoreSO.Value;
    }
    public void ScoreMenu()
    {
        lastScore.text = "Last Score: " + scoreSO.Value;
        totalScore.text = "Total Score: " + totalScoreSO.Value;
    }
}
