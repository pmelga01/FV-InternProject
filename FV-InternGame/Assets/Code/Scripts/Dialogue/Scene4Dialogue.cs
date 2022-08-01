using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class Scene4Dialogue : MonoBehaviour {
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
                Char1name.text = "MR. DAVIS";
                Char1speech.text = "Good morning everyone! I hope you all did the math homework last night because it’s time for a pop quiz!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You groan and place your notebook under your desk.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "CONSTANCE";
                Char1speech.text = "Thank goodness I did it all! This will be a piece of cake.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "CONSTANCE";
                Char1speech.text = "Good luck!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You stare at the math problems and they don’t quite make sense. Your chest tightens and you breathe quicker and quicker. ";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "What did that counselor tell you to do when you were feeling like this? You picture the worksheet in your mind...";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Image:";
                Char2speech.text = " \"Improve the Moment\" ";
        }
        else if (primeInt == 9) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ IMAGERY ~";
            Char2speech.text = "You take a deep breath and think about a calming environment. Ocean waves fill your mind, the sound of seagulls echo, and crashing waves tumble down the shore. You think about the feeling of sunlight on your skin, of warmth, of sand getting stuck between your toes.";
        }
        else if (primeInt == 10) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ IMAGERY ~";
            Char2speech.text = "You breathe out. You are safe.";
        }
        else if (primeInt == 11) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ MEANING ~";
            Char2speech.text = "You try to think about if there could be any meaning to this stress. Maybe you should ask questions in class the next time you don’t understand a lesson.";
        }
        else if (primeInt == 12) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ PRAYER ~";
            Char2speech.text = "You remember the counselor explaining you could pray to a higher power or hope for some strength in the moment to power through the quiz.";
        }
        else if (primeInt == 13) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ PRAYER ~";
            Char2speech.text = "You hope you have the ability to get through this quiz!";
        }
        else if (primeInt == 14) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ RELAXATION ~";
            Char2speech.text = "You squeeze your eyes shut, and relax them, and squeeze them shut again, and relax them again. You tense the muscles in your legs up, and release.";
        }
        else if (primeInt == 15) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ RELAXATION ~";
            Char2speech.text = " You breathe in and out, tensing muscles and relaxing them. You feel grounded in your body.";
        }
        else if (primeInt == 16) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ ONE THING IN THE MOMENT ~";
            Char2speech.text = "You look up and stare at the clock and watch the hand click.";
        }
        else if (primeInt == 17) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ ONE THING IN THE MOMENT ~";
            Char2speech.text = "While focusing on it, you pay attention to the angle of your fingers, to their height off the desk, and to your breaths in and out.";
        }
        else if (primeInt == 18) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ VACATION ~";
            Char2speech.text = "You raise your hand and ask to use the bathroom. A little time away from the quiz mightwill be helpful.";
        }
        else if (primeInt == 19) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ VACATION ~";
            Char2speech.text = "You walk around for a few minutes and go back to the classroom.";
        }
        else if (primeInt == 20) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ ENCOURAGEMENT ~";
            Char2speech.text = "You are your own cheerleader! You imagine yourself holding pom-poms and wearing a fun outfit.";
        }
        else if (primeInt == 21) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "~ ENCOURAGEMENT ~";
            Char2speech.text = " 'You can do it!' the image of you shouts. 'You can do this!' ";
            
        }
        else if (primeInt == 22) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "You look down at the page and the numbers look familiar. You remember one of these problems from the lesson. You pick up your pencil and start to write. ";
        }
        else if (primeInt == 23) {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Time to use 50 energy points to take this quiz!";
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
                // allowSpace = true;
        }
        public void Choice1bFunct(){
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "You";
                // Char2speech.text = "Sure, anything you want... just lay off the club.";
                // primeInt = 199;
                // Choice1a.SetActive(false);
                // Choice1b.SetActive(false);
                // nextButton.SetActive(true);
                // allowSpace = true;
        }

        public void SceneChange1(){
            //hallway scene
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3a");
        }
}
