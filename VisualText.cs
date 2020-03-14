using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VisualText : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float TypingSpeed;
    public GameObject ContinueButton;

     void Start()
    {
        StartCoroutine(Type());
    }

    public void returnspeed()
        
    {
        TypingSpeed = 0.1f;
    }


    public void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            ContinueButton.SetActive(true);

        }
      if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            TypingSpeed--;
        }
      

    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(TypingSpeed);
        }
    }
    public void NextSentences()
    {
        ContinueButton.SetActive(false);
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            
        } else
        {
            textDisplay.text = "";
        }
    }
    


}
