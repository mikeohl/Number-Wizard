/* NumberWizard is a simple binary search number guessing
 * game where the computer guesses the player's number. 
 */

using UnityEngine;
using System.Collections;
using System.Reflection;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// Debug.Log("Up arrow was pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// Debug.log("Down arrow was pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) { 
			print ("I Won!");
			StartGame();
		}
	}
	
	// Initialize values, print introduction, and query user
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
		
		max = max + 1;
	}
	
	// Compute next guess and query user
	void NextGuess () { 
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
	}
	

}
