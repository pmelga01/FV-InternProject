using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class BreakfastDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public TextMeshProUGUI Char1name;
        public TextMeshProUGUI Char1speech;
        public TextMeshProUGUI Char2name;
        public TextMeshProUGUI Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject mainCharacter;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        mainCharacter.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking()
{         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               mainCharacter.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "For breakfast we use food for fuel! Each food has a different nutritional makeup and different amounts of energy points!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "What are energy points? Oh!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4) {
            Char1name.text = "";
            Char1speech.text = "Energy points are a very “scientific” calculation based on what’s in each food that lets you know how much energy it will give you throughout the day!";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "Eating food with energy points will help you stay focused in school, play at recess, and keep your body healthy and strong!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "It is important to remember that all kids have growing bodies that require a wide range of nutrients and food types to keep them fueled and strong!";
                Char2name.text = "";
                Char2speech.text = "";
                
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                
        }
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "You";
                // Char2speech.text = "I don't know what you're talking about!";
                // primeInt = 99;
                // Choice1a.SetActive(false);
                // Choice1b.SetActive(false);
                 nextButton.SetActive(true);
                 allowSpace = true;
        }
        public void Choice1bFunct(){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "You";
                // Char2speech.text = "Sure, anything you want... just lay off the club.";
                // primeInt = 199;
                // Choice1a.SetActive(false);
                // Choice1b.SetActive(false);
                 nextButton.SetActive(true);
                 allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Minigame_Breakfast");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Minigame_Breakfast");
        }
}
