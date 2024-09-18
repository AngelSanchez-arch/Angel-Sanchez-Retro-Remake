using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPM : MonoBehaviour
{
    // Start is called before the first frame update
    public int numberOfItems, score;         // Ints are Whole numbers
    public float health, weight, speed;      // Floats are decimals
    public string amongus, menuLabel, dialouge, characterName;     // Stringings are words/phrases/text
    public bool isEnemyDead, iseffectActive, isgrounded; // Bool represent values that are TRUE or False
    public Vector2  size, playerLocation;    // Vectors2s represent 2-Dimesional Decimals

    void Start()
    {
        Debug.Log("Derek's favorite student is " + characterName);

        if (isgrounded) // Will execute code if true
        {
            Debug.Log("Exploding");        
        }
        else
        {
            Debug.Log("just kidding its actually " + amongus);
        }    
                
                
                
                
     }


    // Update is called once per frame
    void Update()
    {
        
    }
}
