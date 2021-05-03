using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay; //A variable to allow us to control TextMeshPro as it is the text that is shown on the Screen.
    public string[] sentences; //String Array which are the sentences we are printing to the screen
    public TextAsset textFile;
    public float textSpeed;
    private int index;

    public GameObject continueButton; //Two game objects to allow us to continue to the next sentence and once the sentences are finished, the next scene button appears to allow the player to go to the next scene
    public GameObject nextSceneButton;

    void Start()
    {
        if (textFile != null)
        {
            sentences = (textFile.text.Split('\n'));
        }
        StartCoroutine(Type());
    }

    void Update()
    { //Update Method here checks continously whether the sentences have been printed all the way and once it does, it sets the continue Button to true to continue to the next sentence.
      //When all the sentences for the scene has been printed, the next scene button appears to go to the next scene.
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        } else if (index == sentences.Length - 1)
        {
            continueButton.SetActive(false);
            nextSceneButton.SetActive(true);
        }
    }

    IEnumerator Type()
    { //Method to print out each character in the sentences
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(textSpeed);

        }
    }

    public void NextSentence()
    { //Every time a new sentence starts, we set the continue button to disappear
      //As long as the indexes are less than the sentences.length, we increment the index to print the next sentence and set the text first ="" to ensure we are simply appending to the last sentence.
      //Once we set the text to "" we can start the type coroutine which is above that adds each char to the text dialogue that will be printed as they are added.

        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }
}