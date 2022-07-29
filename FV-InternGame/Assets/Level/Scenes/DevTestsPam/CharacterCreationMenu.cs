using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CharacterCreationMenu : MonoBehaviour
{
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RandomizeCharacter()
    {
        foreach(OutfitChanger changer in outfitChangers) {
            changer.Randomize();
        }
    }
    
    public void Submit()
    {
        //different way to save the character 
        // use Scriptible Object 
        // PLayer prefs
        
        #if UNITY_EDITOR
        bool prefabSuccess;
        PrefabUtility.SaveAsPrefabAssetAndConnect(character, "Assets/Level/Scenes/DevTestsPam/Mighty Heroes (Rogue) 2D Fantasy Characters Pack/Prefabs/Player.prefab", InteractionMode.UserAction, out prefabSuccess);
        if (prefabSuccess == true)
                Debug.Log("Prefab was saved successfully");
            else
                Debug.Log("Prefab failed to save" + prefabSuccess);
        SceneManager.LoadScene("MainMenu");
        
        #else
        SceneManager.LoadScene("MainMenu");
        #endif
        
    }
}
