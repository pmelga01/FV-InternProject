using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class Scene8Dialogue : MonoBehaviour {
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
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Before you go, there are some things you really should know!";
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Any meal is always better than no meal!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Food is fuel for your body and your mind!";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Eating different kinds of food gives you different kinds of benefits like nutrients that are good for your bones, muscles, brain, and more!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Fat is not a feeling, and there is no good or bad when it comes to how your body looks.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Getting all the good vitamins and minerals, and eating enough to keep your growing body healthy and strong is what matters";
        }
        else if (primeInt ==8){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "Being kind to yourself and your friends is very important too! Nice job standing up for yourself with Constance but also being kind to her feelings as well.";
         }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "For more info, talk to a trusted adult, a counselor at school, parents and family members, or your doctor! ";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                
                NextScene1Button.SetActive(true);
        }
}
// ENCOUNTER AFTER CHOICE #1
     //   else if (primeInt == 100){
     //            Char1name.text = "Jeda";
     //            Char1speech.text = "Then you are no use to me, and must be silenced.";
     //            Char2name.text = "";
     //            Char2speech.text = "";
     //    }
     //   else if (primeInt == 101){
     //            Char1name.text = "Jeda";
     //            Char1speech.text = "Come back here! Do not think you can hide from me!";
     //            Char2name.text = "";
     //            Char2speech.text = "";
     //            nextButton.SetActive(false);
     //            allowSpace = false;
     //            NextScene1Button.SetActive(true);
     //    }
     // 
     //   else if (primeInt == 200){
     //            Char1name.text = "Jeda";
     //            Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
     //            Char2name.text = "";
     //            Char2speech.text = "";
     //    }
     //   else if (primeInt == 201){
     //            Char1name.text = "";
     //            Char1speech.text = "";
     //            Char2name.text = "You";
     //            Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
     //            nextButton.SetActive(false);
     //            allowSpace = false;
     //            NextScene2Button.SetActive(true);
     //    }
     // }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "You";
                // Char2speech.text = "I don't know what you're talking about!";
                // primeInt = 99;
                // Choice1a.SetActive(false);
                // Choice1b.SetActive(false);
                // nextButton.SetActive(true);
                //allowSpace = true;
        }
        public void Choice1bFunct(){
        //         Char1name.text = "";
        //         Char1speech.text = "";
        //         Char2name.text = "You";
        //         Char2speech.text = "Sure, anything you want... just lay off the club.";
        //         primeInt = 199;
        //         Choice1a.SetActive(false);
        //         Choice1b.SetActive(false);
        //         nextButton.SetActive(true);
        //         allowSpace = true;
        }

        public void SceneChange1(){
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
        public void SceneChange2(){
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
}
