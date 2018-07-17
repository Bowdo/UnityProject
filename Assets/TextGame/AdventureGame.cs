﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    int[] oddNumbers = { 1, 3, 5, 7, 9 };
    string[] firstNames = { "Jake", "John", "Nick", "Fred" };

    State state;

	void Start ()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();

        Debug.Log(oddNumbers[4]);
        Debug.Log(firstNames[2]);
	}
	

	void Update ()
    {
        ManageState();
	}

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            textComponent.text = state.GetStateStory();
        }
       else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            textComponent.text = state.GetStateStory();
        }
    }
}
