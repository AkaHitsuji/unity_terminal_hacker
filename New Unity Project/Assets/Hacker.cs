using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state
    int level;

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;

	// Use this for initialization
    void Start () {
        ShowMainMenu();
	}

    void ShowMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?\n");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("\nEnter your selection:");
    }

    void OnUserInput(string input) {
        if (input == "menu") {
            ShowMainMenu();
        }
        else if (input == "1") {
            level = 1;
            StartGame();
        }
        else if (input == "007") {
            Terminal.WriteLine("Please select a level Mr Bond!");
        }
        else {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame() {
        Terminal.WriteLine("You have chosen level " + level);
    }
	// Update is called once per frame
	void Update () {
		
	}

   
}
