using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int playerScore = 0;
    private bool isGameStarted = false;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject restartButton;

    private void Awake() 
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        isGameStarted = true;
    }

    private void Update() 
    {
        playerScoreText.text = DataManager.Instance.PlayerName + ": " + playerScore;    
    }

    public bool CheckGameStatus()
    {
        return isGameStarted;
    }

    public void IncrementScore()
    {
        playerScore += 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void OnTriggerEnter(Collider other) 
    {
        isGameStarted = false;
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
    }
}
