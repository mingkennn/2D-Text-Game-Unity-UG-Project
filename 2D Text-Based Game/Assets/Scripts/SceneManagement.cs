using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagement: MonoBehaviour { 

    //Boolean Variables to ascertain whether the player has collected the clues
    public static bool canteenClue1 = false;
    public static bool canteenClue2 = false;
    public static bool cafeClue = false;
    public static bool libraryClue = false;
    public static bool QueensMemories = false;
    public static bool PalaceMemories = false;

    //The two game objects representing the choices players make in the first interactive scene
    public GameObject choice1;
    public GameObject choice2;
    public GameObject goBackText;


    void Start()
    {
        //Ensures that the an instance of scene Manager is always in tact and therefore would allow the scene to be maintained
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    public void leaveCanteen()
    {

        //This method checks which clues that the player has collected so far and enables the corresponding choices to the clues they have collected
        if (canteenClue1 == false && canteenClue2 == true)
        {
            choice1.SetActive(false);
            choice2.SetActive(true);
            goBackText.SetActive(false);

        }
        else if (canteenClue1 == true && canteenClue2 == false)
        {
            choice1.SetActive(true);
            choice2.SetActive(false);
            goBackText.SetActive(false);

        }
        else if (canteenClue1 == false && canteenClue2 == false)
        {
            choice1.SetActive(false);
            choice2.SetActive(false);
            goBackText.SetActive(true);

        }
        else
        {
            choice1.SetActive(true);
            choice2.SetActive(true);
            goBackText.SetActive(false);
        }

    }



    public void clue1found()
    {
        //Method to change the variable when the clue has been found by the player
        canteenClue1 = true;
    }

    public void clue2found()
    {
        //Method to change the variable when the clue has been found by the player
        canteenClue2 = true;
    }

    public void clue3found()
    {
        //Method to change the variable when the clue has been found by the player
        cafeClue = true;
    }

    public void clue4found()
    {
        //Method to change the variable when the clue has been found by the player
        libraryClue = true;
    }

    //The methods below are primarily used to load the next scenes and provide a flow to the story
    public void Quit()
    {
        //Quits the Game
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void GateToCafeteria()
    {
        SceneManager.LoadScene(2);
    }

    public void OutsideCafeteria()
    {
        SceneManager.LoadScene(3);
    }

    public void InteractiveCafeteria()
    {
        SceneManager.LoadScene(4);
    }

    public void Option2CafeteriatoLibrary()
    {
        SceneManager.LoadScene(5);
    }

    public void Option1CafeteriaToGround()
    {
        SceneManager.LoadScene(6);
    }

    public void Option2LibrarySquare()
    {
        SceneManager.LoadScene(7);
    }

    public void PreOutsideGround()
    {
        SceneManager.LoadScene(8);
    }

    public void OutsideGround()
    {
        SceneManager.LoadScene(9);
    }

    public void InteractiveGround()
    {
        SceneManager.LoadScene(10);
    }

    public void GroundtoLibrary()
    {
        SceneManager.LoadScene(11);
    }

    public void InteractiveLibrarySquare()
    {
        SceneManager.LoadScene(12);
    }

    public void TurnleftCrossRoads()
    {
        SceneManager.LoadScene(13);
    }

    public void CrossRoads()
    {
        SceneManager.LoadScene(14);

    }

    public void CrossRoadsDrapers()
    {
        SceneManager.LoadScene(15);
    }

    public void QueensBuilding()
    {
        SceneManager.LoadScene(16);

    }

    public void PeoplePalace()
    {
        SceneManager.LoadScene(17);
    }

    public void Drapers()
    {
        SceneManager.LoadScene(18);
    }

    public void EndingScreen()
    {
        SceneManager.LoadScene(21);
    }

    //These are checks in the interactive scenes to ensure that the player has selected a clue.
    public void NoClueInteractiveGround()
    {
        //If they find the clue, they are allowed to progress the story else they are sent to the please find clue scene
        if (cafeClue == true)
        {
            SceneManager.LoadScene(11);
        } else
        {
            SceneManager.LoadScene(19);
        }
    }
        

    public void NoClueInteractiveLibrary()
    {
        //If they find the clue, they are allowed to progress the story else they are sent to the please find clue scene
        if (libraryClue == true)
        {
            SceneManager.LoadScene(13);
        } else
        {
            SceneManager.LoadScene(20);
        }
        
    }

    




}
