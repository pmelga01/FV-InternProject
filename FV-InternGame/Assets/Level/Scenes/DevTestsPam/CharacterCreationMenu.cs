using System.Collections;
using System.Collections.Generic;
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
        //PrefabUtility.SaveAsPrefabAsset(character, "Assets/Level/Scenes/DevTestsPam/Mighty Heroes (Rogue) 2D Fantasy Characters Pack/Prefabs/Player.prefab");
        //SceneManager.LoadScene(1);
    }
}
