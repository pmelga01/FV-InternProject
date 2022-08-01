using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class AvatarDialogue1 : MonoBehaviour {
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
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameObject characterCreationMenu;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
        public bool hasMadeAChange = false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        characterCreationMenu.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
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
        if (hasMadeAChange) {
            nextButton.SetActive(true);
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1) {
                // AudioSource.Play();
        }
        else if (primeInt == 2) {
               //ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "Select all the options that feel the best for you!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3) {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
                ArtBG1.SetActive(false);
                allowSpace = false;
                
                characterCreationMenu.SetActive(true);
                
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4) {
                hasMadeAChange = false;
                Char1name.text = "";
                Char1speech.text = "Nice fit, you look awesome! Let’s go get some breakfast before we head off to school";
                Char2name.text = "";
                Char2speech.text = "";
                
                
                nextButton.SetActive(false);
                characterCreationMenu.SetActive(false);
                allowSpace = false;
                
                DialogueDisplay.SetActive(true);
                NextScene1Button.SetActive(true);
        }
    }
     

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }
        
        public void playerCanSubmit() {
            hasMadeAChange = true;
        }
}
