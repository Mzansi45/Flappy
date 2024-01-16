using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScripts : MonoBehaviour
{
    public int playerScore;
    public Text TextScore;
    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        TextScore.text = playerScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
