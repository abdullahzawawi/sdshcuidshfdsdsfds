using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EmoteDiego : MonoBehaviour
{
    public float pressedd;
    
    public SpriteRenderer emotedd;
  
 
   
   
    public List<Sprite> myList = new List<Sprite>();

    // Start is called before the first frame update
    public void clickedd()
    {
        pressedd++;
    }

    // Update is called once per frame
    void Update()
    {
        if (pressedd == 1) {
            GetComponent<SpriteRenderer>().sprite = myList[1];
            emotedd.sprite = myList[1];
        }
        if (pressedd == 2)
        {






        }
        if (pressedd == 3)
        {
            GetComponent<SpriteRenderer>().sprite = myList[3];
            emotedd.sprite = myList[3];
            
        }
        if (pressedd == 4)
        {
            GetComponent<SpriteRenderer>().sprite = myList[4];
            emotedd.sprite = myList[4];
            
        }
        if (pressedd == 5)
        {
            GetComponent<SpriteRenderer>().sprite = myList[5];
            emotedd.sprite = myList[5];

        }
        if (pressedd == 6)
        {
            GetComponent<SpriteRenderer>().sprite = myList[6];
            emotedd.sprite = myList[6];
           

        }
        if (pressedd == 7)
        {
            GetComponent<SpriteRenderer>().sprite = myList[7];
            emotedd.sprite = myList[7];
          
        }
        if (pressedd == 8)
        {
            GetComponent<SpriteRenderer>().sprite = myList[8];
            emotedd.sprite = myList[8];

        }
        if (pressedd == 9)
        {
          
        }
        if (pressedd == 10)
        {
            GetComponent<SpriteRenderer>().sprite = myList[10];
            emotedd.sprite = myList[10];
            
        }
        if (pressedd == 11)
        {
            GetComponent<SpriteRenderer>().sprite = myList[0];
            emotedd.sprite = myList[0];
            
            
        }
        if (pressedd == 12)
        {
            GetComponent<SpriteRenderer>().sprite = myList[0];
            emotedd.sprite = myList[0];


        }
        if (pressedd == 13)
        {
            GetComponent<SpriteRenderer>().sprite = myList[0];
            emotedd.sprite = myList[0];
        }
        if (pressedd == 14)
        {
            GetComponent<SpriteRenderer>().sprite = myList[14];
            emotedd.sprite = myList[14];
        }
        if (pressedd == 15)
        {
            GetComponent<SpriteRenderer>().sprite = myList[0];
            emotedd.sprite = myList[0];
        }
        if (pressedd == 16)
        {
            
        }
        if (pressedd == 17)
        {
            
        }
        if (pressedd == 18)
        {
            GetComponent<SpriteRenderer>().sprite = myList[14];
            emotedd.sprite = myList[14];
        }
        if (pressedd == 19)
        {
            
        }
        if (pressedd == 20)
        {
           
        }
        if (pressedd == 21)
        {
           
        }

        if (pressedd == 22)
        {
            GetComponent<SpriteRenderer>().sprite = myList[22];
            emotedd.sprite = myList[22];
           
        }
        if (pressedd == 23)
        {
            GetComponent<SpriteRenderer>().sprite = myList[23];
            emotedd.sprite = myList[23];

        }
        if (pressedd == 26)
        {

            
        }
        if (pressedd == 27)
        {

            
        }
        if (pressedd == 28)
        {

          
        }

        if (pressedd == 29)
        {
            
            
        }
        if (pressedd == 30)
        {

            
        }
    }

    public void Start()
    {
        
    }


}
