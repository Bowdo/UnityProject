using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    void Start ()  // Use this for initialization
    {
        StartGame();
    }
    void Update() // Update is called once per frame
    {
        PlayerInputs();
    }

    void StartGame()
    {
         max = 1000;
         min = 1;
         guess = 500;

        Debug.Log("Pick a number, don't tell me what it is");
        Debug.Log("The max number you can pick is: " + max + ", the lowest number you can pick is: " + min);
        Debug.Log("Is your number high or lower than " + guess);
        Debug.Log("Press Up for higher, press Down for lower and press Enter if it's correct");
        max = max + 1;
    }
    void PlayerInputs()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // Up Key input
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("So is your number higher than: " + guess);


        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) // Down Key input
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("So is your number lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return)) // Enter Key input
        {
            Debug.Log(guess + " is your guess");
            StartGame();
        }
    }
	

}
