using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    //References the sprite to change
    public SpriteRenderer bodyPart;
    public Image prev;
    public Image next;
    
    //Sprites to cycle through
    public List<Sprite> options = new List<Sprite>();
    
    private int currOption = 0;
    // Start is called before the first frame update
    void Start()
    {
        changeCarousel();
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
        changeCarousel();
    }
    
    public void PreviousOption()
    {
        currOption--;
        
        if (currOption < 0) {
            currOption = options.Count - 1;
        }
        
        bodyPart.sprite = options[currOption];
        changeCarousel();
    }
    
    public void Randomize()
    {
        currOption = Random.Range(0, options.Count);
        bodyPart.sprite = options[currOption];
        changeCarousel();
    }
    
    void changeCarousel()
    {
        if (currOption == 0) {
            /* If it is the first option, 
                previous option is last option in list
                next option is second option in list */
            prev.sprite = options[options.Count - 1];
            next.sprite = options[currOption + 1];
            
        } else if (currOption == options.Count - 1) {
            /* If it is the last option, 
                previous option is last - 1
                next option is first option */
            prev.sprite = options[currOption - 1];
            next.sprite = options[0];
            
        } else {
            prev.sprite = options[currOption - 1];
            next.sprite = options[currOption + 1];
        }
    }
}
