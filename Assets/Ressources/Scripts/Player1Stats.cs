using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Stats : MonoBehaviour
{
    public static float blueTimer;
    public float startTimer = 5f; 
    // Start is called before the first frame update
    void Start()
    {
        blueTimer = startTimer;
    }
}
