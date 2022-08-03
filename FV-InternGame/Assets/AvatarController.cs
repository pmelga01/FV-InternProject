using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    [SerializeField]
    private CharacterArtScriptableObject playerArt;
    /* Screen1  */
        // skin color
    public SpriteRenderer head;
    public SpriteRenderer eyes;
        //body type
    public SpriteRenderer arms;
    public SpriteRenderer shirt;
    public SpriteRenderer pants;
    
    /* Screen2 */
    public SpriteRenderer frontHair;
    public SpriteRenderer backHair;
    
    /* Screen3 */
    public SpriteRenderer addOns;
    
    // Start is called before the first frame update
    void Start()
    {
        updateCharacterArt();
    }
    
    //how do i keep the most up to date NUMBER choice for the Character
       //during the game 
       //and during the selection
       
    //we're updating the choices based on the carousel selection.
        // outfitchanger: currOption
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void updateCharacterArt()
    {
        head.color = playerArt.getSkinColor;
        eyes.color = playerArt.getEyeColor;
        arms.sprite = playerArt.getBodyTypeArms;
        arms.color = playerArt.getSkinColor;
        shirt.sprite = playerArt.getBodyTypeTorso;
        shirt.color = playerArt.getShirtColor;
        pants.sprite = playerArt.getBodyTypeBottom;
        pants.color = playerArt.getPantsColor;
        frontHair.sprite = playerArt.getFrontHair;
        frontHair.color = playerArt.getHairColor;
        backHair.sprite = playerArt.getBackHair;
        backHair.color = playerArt.getHairColor;
        addOns.sprite = playerArt.getAccessories;
    }
}
