using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class CharacterCreationMenu : MonoBehaviour
{
    [SerializeField] 
    private CharacterArtScriptableObject playerArt;
    public AvatarController avatarController;
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
    
    public void updateArtChoice()
    {
        
        avatarController.updateCharacterArt();
    }
    
    
    public void RandomizeCharacter()
    {
        foreach(OutfitChanger changer in outfitChangers) {
            changer.Randomize();
        }
        
        updateArtChoice();
    }
    
    public void Submit()
    {
        //different way to save the character 
        // use Scriptible Object 
        // PLayer prefs
        
        //save the changes somehow, scene changes taken care of in another script
        
    }
}
