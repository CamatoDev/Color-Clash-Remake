using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Pour le fondu
    public SceneFader sceneFader;
    public AudioSource audioSource;

    public Text redResult;
    public Text blueResult;
    public Text blueScore;
    public Text redScore;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;

        if (GameManager.blueNodeNumber > GameManager.redNodeNumber)
        {
            blueResult.text = "You Win";
            blueScore.text = "Score : " + GameManager.blueNodeNumber;

            redResult.text = "You Lose";
            redScore.text = "Score : " + GameManager.redNodeNumber;
        }

        if (GameManager.blueNodeNumber < GameManager.redNodeNumber)
        {
            blueResult.text = "You Lose";
            blueScore.text = "Score : " + GameManager.blueNodeNumber;

            redResult.text = "You Win";
            redScore.text = "Score : " + GameManager.redNodeNumber;
        }

        if (GameManager.blueNodeNumber == GameManager.redNodeNumber)
        {
            blueResult.text = "You Win";
            blueScore.text = "Score : " + GameManager.blueNodeNumber;

            redResult.text = "You Win";
            redScore.text = "Score : " + GameManager.redNodeNumber;
        }
    }

    public void Restart()
    {
        // Recharger la scene actuel
        audioSource.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        audioSource.Play();
        sceneFader.FadeTo("MainMenu");
    }
}
