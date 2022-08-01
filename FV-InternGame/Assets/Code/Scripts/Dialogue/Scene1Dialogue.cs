using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public TextMeshProUGUI Char1name;
        public TextMeshProUGUI Char1speech;
        public TextMeshProUGUI Char2name;
        public TextMeshProUGUI Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
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
        ArtChar1.SetActive(false);
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
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               //ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "Good morning friend! Welcome to Aplomb Adventures! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Today we’re going to learn and practice some skills that will help you improve your confidence inside and out!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "Let’s go customize your character and get ready for the day!";
                Char2name.text = "";
                Char2speech.text = "";
                //Turn off "Next" button, turn on Scene Change button to Avatar Creator
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
    }
     

    public void SceneChange1(){
           SceneManager.LoadScene("AvatarCreationStart_test");
    }
    public void SceneChange2(){
            SceneManager.LoadScene("Scene2a");
    }
    
}
