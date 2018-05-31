using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    private int gMin;
    private int gMax;
    private int guess;
    private string userRes;

    void guessNumber(int givenMin, int givenMax)
    {
        guess = Random.Range(givenMin, givenMax);
        gMin = givenMin;
        gMax = givenMax;
        Debug.Log("Min: "+gMin);
        Debug.Log("Max: "+gMax);
        Debug.Log(string.Format("Is your number [H]igher or [L]ower than {0}? \n" +
                                    "H: It's higher. \n" +
                                    "L: It's lower. \n" +
                                "N: Whoa! That's my number!", guess));
    }

    // Use this for initialization
    void Start () {
        gMin = 1;
        gMax = 1000;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log(string.Format(
                "Choose a number between {0} and {1}... \n" +
                " I will try to guess this number:",
            gMin,
            gMax
        ));
        userRes = "";
        guessNumber(gMin, gMax);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.H)))
        {
            userRes = "H";
        }
        else if ((Input.GetKeyDown(KeyCode.L)))
        {
            userRes = "L";
        }
        else if ((Input.GetKeyDown(KeyCode.Keypad3)) || (Input.GetKeyDown(KeyCode.Alpha3)))
        {
            userRes = "N";
        }
        if (userRes != "")
        {
            switch (userRes)
            {
                case "H": // Guessed number is higher than user number
                    guessNumber(guess, gMax);
                    break;
                case "L": // Guessed number is lower than user number
                    guessNumber(gMin, guess);
                    break;
                case "N": // Guessed number is correct
                    Debug.Log(string.Format("I knew it! {0} is the number you were thinking of!", guess));
                    break;
            }
        }
        userRes = "";
    }
}
