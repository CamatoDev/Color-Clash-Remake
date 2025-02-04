using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Game State")]
    public Image colorBarProggression; // Jouer avec l'alpha
    public float maxBluePoint = 448;
    public static float bluePoint;
    public float gameTime = 60f;
    public Text timeBlue;
    public Text timeRed;

    [Header("Game Ended")]
    public GameObject EndGameUI;
    public GameObject[] nodes; // Gerer avec le foreach 
    public static int blueNodeNumber;
    public static int redNodeNumber;

    bool gameEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        // Valeur des departs des variables 
        gameTime = 90f;
        bluePoint = 224f;
        blueNodeNumber = 0;
        redNodeNumber = 0;
        gameEnd = false;
        EndGameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnd)
        {
            return;
        }

        // Affichage du remplissage de la barre de progression de couleur
        colorBarProggression.fillAmount = bluePoint / maxBluePoint;
        // Affichage du temps pour les deux joueurs 
        timeBlue.text = string.Format("{0:00}", gameTime);
        timeRed.text = string.Format("{0:00}", gameTime);

        // Actualisation du temps en fonction de la frameRate
        gameTime -= Time.deltaTime;
        gameTime = Mathf.Clamp(gameTime, 0f, Mathf.Infinity);

        if (gameTime <= 0f)
        {
            foreach (GameObject node in nodes)
            {
                if(node.tag == "NodeBlue")
                {
                    blueNodeNumber += 1;
                }

                if(node.tag == "NodeRed")
                {
                    redNodeNumber += 1;
                }
            }
            EndGame();
        }
    }

    public void EndGame()
    {
        gameEnd = true;
        Debug.Log("Partie Terminée !!");
        EndGameUI.SetActive(true); // Créer et coder l'objet
    }
}
