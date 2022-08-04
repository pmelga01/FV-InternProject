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
    
    //public OutfitChanger skinColorNum;
    public OutfitChanger bodyChoiceNum;
    //ublic OutfitChanger eyeColorNum;
    public OutfitChanger frontHairNum;
    public OutfitChanger backHairNum;
    //public OutfitChanger hairColorNum;
    //public OutfitChanger shirtColorNum;
    //public OutfitChanger pantsColorNum;
    //public OutfitChanger accessoryNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }
    
    public void updateArtChoice()
    {
        //playerArt.skinChoice = skinColorNum.currOption;
        playerArt.bodyChoice = bodyChoiceNum.currOption;
        //playerArt.eyeColorChoice = eyeColorNum.currOption;
        playerArt.frontHairChoice = frontHairNum.currOption;
        playerArt.backHairChoice = backHairNum.currOption;
        //playerArt.shirtColorChoice = shirtColorNum.currOption;
        //playerArt.pantsColorChoice = pantsColorNum.currOption;
        //playerArt.accessoryChoice = accessoryNum.currOption;
        
        avatarController.updateCharacterArt();
    }
    
    
    public void RandomizeCharacter()
    {
        foreach(OutfitChanger changer in outfitChangers) {
            changer.Randomize();
        }
        
        updateArtChoice();
    }
    
}
