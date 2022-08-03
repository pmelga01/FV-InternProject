using UnityEngine;

[CreateAssetMenu(fileName = "CharacterArtScriptableObject", menuName = "ScriptableObjects/CharacterArt")]
public class CharacterArtScriptableObject : ScriptableObject
{
    //Screen 1
    [SerializeField]
    private Color[] skinColor;
    [SerializeField]
    private Sprite[] bodyTypeTorso;
    [SerializeField]
    private Sprite[] bodyTypeArms;
    [SerializeField]
    private Sprite[] bodyTypeBottom;
    [SerializeField]
    private Color[] eyeColor;
    public int skinChoice = 0;
    public int bodyChoice = 0;
    public int eyeColorChoice = 0;
    
    //Screen 2
    [SerializeField]
    private Sprite[] frontHair;
    [SerializeField]
    private Sprite[] backHair;
    [SerializeField]
    private Color[] hairColor;
    public int frontHairChoice = 0;
    public int backHairChoice = 0;
    public int hairColorChoice = 0;
    
    //Screen 3
    [SerializeField]
    private Color[] shirtColor;
    [SerializeField]
    private Color[] pantsColor;
    [SerializeField]
    private Sprite[] accessories;
    public int shirtColorChoice = 0;
    public int pantsColorChoice = 0;
    public int accessoryChoice = 0;
    
    public Color getSkinColor
    {
        get
        {
            return skinColor[skinChoice];
        }
    }
    
    public Color getEyeColor
    {
        get
        {
            return eyeColor[eyeColorChoice];
        }
    }
    
    public Color getHairColor
    {
        get
        {
            return hairColor[hairColorChoice];
        }
    }
    
    public Color getShirtColor
    {
        get
        {
            return shirtColor[shirtColorChoice];
        }
    }
    
    public Color getPantsColor
    {
        get
        {
            return pantsColor[pantsColorChoice];
        }
    }
    
    public Sprite getBodyTypeTorso
    {
        get
        {
            return bodyTypeTorso[bodyChoice];
        }
    }
    
    public Sprite getBodyTypeArms
    {
        get
        {
            return bodyTypeArms[bodyChoice];
        }
    }
    
    public Sprite getBodyTypeBottom
    {
        get
        {
            return bodyTypeBottom[bodyChoice];
        }
    }
    
    public Sprite getFrontHair
    {
        get
        {
            return frontHair[frontHairChoice];
        }
    }
    
    public Sprite getBackHair
    {
        get
        {
            return backHair[backHairChoice];
        }
    }
    
    public Sprite getAccessories
    {
        get
        {
            return accessories[accessoryChoice];
        }
    }
    
}
