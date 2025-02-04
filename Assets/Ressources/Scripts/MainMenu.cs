using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public SceneFader sceneFader;
    public string levelToLoad = "Level01";

    public AudioSource audioSource;
    public void Play()
    {
        audioSource.Play();
        sceneFader.FadeTo(levelToLoad);
    }

    public void Quit()
    {
        audioSource.Play();
        Debug.Log("Quitter le jeu !");
        Application.Quit();
    }
}
