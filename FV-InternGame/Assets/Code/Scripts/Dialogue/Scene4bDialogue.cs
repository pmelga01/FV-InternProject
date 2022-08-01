using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class Scene4bDialogue : MonoBehaviour {
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
public void talking()
{         // main story function. Players hit next to progress to next int
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
                Char2speech.text = "Now it’s lunchtime!";
        }
        else if (primeInt == 3) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Peanut Butter and Jelly sandwich, Apple, Chips, Burger";
        }
        else if (primeInt == 4) {
            Char1name.text = "CONSTANCE";
            Char1speech.text = "I think I’m just going to have an apple and chips. I feel so fat today.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Her words makes you feel weird. Your mom always said that fat isn’t a feeling, it’s just a body.";
        }
        else if (primeInt == 6) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "You think back to your counselor explaining how to explain your feelings to someone. You remember DEAR.";
        }
        else if (primeInt == 7) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ Describe: ~";
            Char2speech.text = "Describe the situation";
        }
        else if (primeInt == 8) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "You made a comment about weight, and I think you shouldn’t say things like that.";
        }
        else if (primeInt == 9) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = " ~ Express: ~";
            Char2speech.text = "Explain how it made you feel";
        }
        else if (primeInt == 10) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "It made me feel uncomfortable to hear you equate a body type with a negative feeling.";
        }
        else if (primeInt == 11) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = " ~ Assert: ~";
            Char2speech.text = "Ask for something specific";
        }
        else if (primeInt == 12) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "In the future, can you not say that?";
        }
        else if (primeInt == 13) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = " ~ Reinforce: ~";
            Char2speech.text = "Explain the good outcomes! Be kind!";
        }
        else if (primeInt == 14) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "It would make me feel really good if you’d be respectful to everyone. Thank you!";
        }
        else if (primeInt == 15) {
            Char1name.text = "CONSTANCE";
            Char1speech.text = "I’m sorry! Thank you for telling me all of that.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 16) {
            Char1name.text = "CONSTANCE";
            Char1speech.text = "I’ve heard that at home, but I’ve never really thought about what I was actually saying. I promise to not do that in the future!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 17) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "We should probably reassure Constance her body is good just the way it is, and that fat is not a feeling!";
        }
        else if (primeInt == 18) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Constance, we all need to eat lunch to keep us healthy and strong!";
        }
        else if (primeInt == 19) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Not eating enough at lunch is way worse than eating a filling meal, you won’t have enough energy to focus in class or play in gym class!";
        }
        else if (primeInt == 20) {
            Char1name.text = "CONSTANCE";
            Char1speech.text = "You’re right, I should probably get a sandwich or burger too…";
            Char2name.text = "";
            Char2speech.text = "";
        }    
        else if (primeInt == 21) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "YOU";
            Char2speech.text = "Plus, fat isn’t a feeling, and bodies don’t need to be changed to be good. You are good just the way you are!";
        }
        else if (primeInt == 22) {
            Char1name.text = "CONSTANCE";
            Char1speech.text = "Thanks! That means a lot!";
            Char2name.text = "";
            Char2speech.text = "";
            NextScene1Button.SetActive(true);
            allowSpace = false;
            nextButton.SetActive(false);
        }    
       
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "I don't know what you're talking about!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Sure, anything you want... just lay off the club.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene5a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5a");
        }
}
