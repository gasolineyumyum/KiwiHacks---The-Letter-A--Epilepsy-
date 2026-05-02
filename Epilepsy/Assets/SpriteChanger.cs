using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    
    [SerializeField] Sprite[] characterSprites;
    [SerializeField] Sprite newSprite;

    int cur_character_sprite = 0;

    private void function()
    {
        cur_character_sprite++;
        newSprite = characterSprites[cur_character_sprite];

        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
    }
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        for(int i = 0; i < 5; i++)
        {
            // REMEMBER TO CHANGE THIS TO THE ACTUAL TIME WHEN IT CHANGES
            yield return new WaitForSeconds(18);
            function();
        }
        
    }
}
