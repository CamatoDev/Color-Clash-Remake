using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Stats : MonoBehaviour
{
    public static float redTimer;
    public float startTimer = 2f;
    public float maxTime = 10f;
    public Image redEnergie;

    // Start is called before the first frame update
    void Start()
    {
        redTimer = startTimer;
    }

    private void Update()
    {
        // Affichage de la barre d'energie 
        redEnergie.fillAmount = redTimer / maxTime;

        if (redTimer < maxTime)
        {
            //On ajoute 
            redTimer += Time.deltaTime;
        }
        if(redTimer >= maxTime)
        {
            //On reduit
            redTimer = maxTime;
        }
    }
}
