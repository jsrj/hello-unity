using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    void Start () {
        int min = 1;
        int max = 1000;
        int guessedNumber = 0;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log(string.Format(
                "Choose a number between {0} and {1}... \n" +
                " I will try to guess this number:",
            min,
            max
        ));
        while(guessedNumber == 0) {
            int currentGuess = Random.Range(min, max);
            int userInput = -1;
            switch (userInput) {
                case 1: // Guessed number is higher than user number
                    max = currentGuess;
                    break;
                case 2: // Guessed number is lower than user number
                    min = currentGuess;
                    break;
                case 3: // Guessed number is correct
                    guessedNumber = currentGuess;
                    break;    
            }
        }
    }

    // Update is called once per frame
    void Update () {
        
    }
}
