using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int min = 1;
        int max = 1000;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log(
            string.Format("Choose a number between {0} and {1}... \n" +
                          " I will try to guess this number:",
            min,
            max
        ));
        //Debug.Log(string.Format("Hello, {0}", myName));
	}

	// Update is called once per frame
	void Update () {
		
	}
}
