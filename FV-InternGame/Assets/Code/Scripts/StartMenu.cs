using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void QuitGame() 
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
    
    public void StartGame() 
    {
        SceneManager.LoadScene("Scene1a");
    }
    
    public void AvatarCreator()
    {
        SceneManager.LoadScene("AvatarCreationStart_test");
    }
}
