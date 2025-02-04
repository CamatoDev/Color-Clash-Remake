using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Stats : MonoBehaviour
{
    public static float blueTimer;
    public float startTimer = 2f;
    public float maxTime = 10f;
    public Image blueEnergie;
    public 
    // Start is called before the first frame update
    void Start()
    {
        blueTimer = startTimer;
    }

    private void Update()
    {
        // Affichage de la barre d'energie 
        blueEnergie.fillAmount = blueTimer / maxTime;

        if (blueTimer < maxTime)
        {
            //On ajoute 
            blueTimer += Time.deltaTime;
        }
        if (blueTimer >= maxTime)
        {
            //On reduit
            blueTimer = maxTime;
        }
    }
}
