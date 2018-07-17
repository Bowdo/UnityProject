using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

	void Start ()
    {
        textComponent.text = ("You wake up from a loud bang, you yourself in a empty white room with 2 doors. The doors are labeled as Fantasy Land and Real World");
	}
	

	void Update ()
    {
		
	}
}
