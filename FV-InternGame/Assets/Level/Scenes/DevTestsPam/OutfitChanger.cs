using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    //References the sprite to change
    public SpriteRenderer bodyPart;
    
    //Sprites to cycle through
    public List<Sprite> options = new List<Sprite>();
    
    private int currOption = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void NextOption()
    {
        currOption++;
        
        if (currOption >= options.Count) {
            currOption = 0;
        }
        
        bodyPart.sprite = options[currOption];
    }
    
    public void PreviousOption()
    {
        currOption--;
        
        if (currOption < 0) {
            currOption = options.Count - 1;
        }
        
        bodyPart.sprite = options[currOption];
    }
    
    public void Randomize()
    {
        currOption = Random.Range(0, options.Count - 1);
        bodyPart.sprite = options[currOption];
    }
}
