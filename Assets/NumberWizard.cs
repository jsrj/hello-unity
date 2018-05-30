using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    void guessNumber(int givenMin, int givenMax)
    {
        int currentGuess = Random.Range(givenMin, givenMax);
        int currentMin = givenMin;
        int currentMax = givenMax;

        Debug.Log(string.Format("Is your number {0}? /n" +
                                    "1: No, its higher than my number. \n" +
                                    "2: No, its lower than my number. \n" +
                                    "3: Yes! That is my number!"));
        int userInput = -1;
        if ((Input.GetKeyDown(KeyCode.Keypad1)) || (Input.GetKeyDown(KeyCode.Alpha1)))
        {
            userInput = 1;
        }
        else if ((Input.GetKeyDown(KeyCode.Keypad2)) || (Input.GetKeyDown(KeyCode.Alpha2)))
        {
            userInput = 2;
        }
        else if ((Input.GetKeyDown(KeyCode.Keypad3)) || (Input.GetKeyDown(KeyCode.Alpha3)))
        {
            userInput = 3;
        }
        switch (userInput)
        {
            case 1: // Guessed number is higher than user number
                //guessNumber(givenMin, currentGuess);
                break;
            case 2: // Guessed number is lower than user number
                //guessNumber(currentGuess, givenMax);
                break;
            case 3: // Guessed number is correct
                Debug.Log(string.Format("I knew it! {0} is the number you were thinking of!", currentGuess));
                break;
        }
    }

    // Use this for initialization
    void Start () {
        int min = 1;
        int max = 1000;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log(string.Format(
                "Choose a number between {0} and {1}... \n" +
                " I will try to guess this number:",
            min,
            max
        ));
        //guessNumber(min, max);
    }

    // Update is called once per frame
    void Update () {
        
    }
}
