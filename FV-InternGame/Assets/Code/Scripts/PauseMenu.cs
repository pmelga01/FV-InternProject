using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour  {

        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;
        
        private GameObject meter;
        private GameObject needle;
        private GameObject ball;

        void Awake (){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                meter = GameObject.Find("meter");
                needle = GameObject.Find("needle");
                ball = GameObject.Find("ball");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start ()
        {
            pauseMenuUI.SetActive(false);
                
        }

        void Update ()
        {
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
        }

    void Pause()
    {
        meter.SetActive(false);
        needle.SetActive(false);
        ball.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

        public void Resume()
        {
            meter.SetActive(true);
            needle.SetActive(true);
            ball.SetActive(true);
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameisPaused = false;
        }

        public void Restart()
        {
                Time.timeScale = 1f;
                //restart the game:
                //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
                SceneManager.LoadScene("MainMenu");
        }

      public void QuitGame() 
      {
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
      }

        public void SetLevel (float sliderValue)
        {
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }
}