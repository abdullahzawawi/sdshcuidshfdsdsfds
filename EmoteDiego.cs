using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EmoteChangeRuler : MonoBehaviour
{
    public float pressedd;
    public GameObject player;
    public SpriteRenderer emotedd;
    public GameObject name;
    public TextMeshProUGUI name2;
    public Animator playerr;
    public GameObject diego;
   
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
            name.SetActive(false);
        }
        if (pressedd == 4)
        {
            GetComponent<SpriteRenderer>().sprite = myList[4];
            emotedd.sprite = myList[4];
            name.SetActive(true);
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
            name2.SetText("Henry");
            playerr.Play("OMG");

        }
        if (pressedd == 7)
        {
            GetComponent<SpriteRenderer>().sprite = myList[7];
            emotedd.sprite = myList[7];
            name2.SetText("Kira");
        }
        if (pressedd == 8)
        {
            GetComponent<SpriteRenderer>().sprite = myList[8];
            emotedd.sprite = myList[8];

        }
        if (pressedd == 9)
        {
            name2.SetText("Henry");
        }
        if (pressedd == 10)
        {
            GetComponent<SpriteRenderer>().sprite = myList[10];
            emotedd.sprite = myList[10];
            
        }
        if (pressedd == 11)
        {
            GetComponent<SpriteRenderer>().sprite = myList[11];
            emotedd.sprite = myList[11];
            name2.SetText("???");
            diego.SetActive(true);
        }
        if (pressedd == 12)
        {
            GetComponent<SpriteRenderer>().sprite = myList[12];
            emotedd.sprite = myList[12];
            name2.SetText("Kira");

        }
        if (pressedd == 13)
        {
            name2.SetText("Henry");
        }
        if (pressedd == 14)
        {
            name2.SetText("???");
        }
        if (pressedd == 15)
        {
            name2.SetText("Henry");
        }
        if (pressedd == 16)
        {
            name.SetActive(false);
        }
        if (pressedd == 17)
        {
            name.SetActive(true);
            name2.SetText("Henry");
        }
        if (pressedd == 18)
        {
            name2.SetText("???");
        }
        if (pressedd == 19)
        {
            name2.SetText("Henry");
        }
        if (pressedd == 20)
        {
            name.SetActive(false);
        }
        if (pressedd == 21)
        {
            name.SetActive(true);
            name2.SetText("Kira");
        }

        if (pressedd == 22)
        {
            GetComponent<SpriteRenderer>().sprite = myList[22];
            emotedd.sprite = myList[22];
            name2.SetText("???");
        }
        if (pressedd == 23)
        {
            GetComponent<SpriteRenderer>().sprite = myList[23];
            emotedd.sprite = myList[23];

        }
        if (pressedd == 26)
        {

            name2.SetText("Kira");
        }
        if (pressedd == 27)
        {

            name2.SetText("???");
        }
        if (pressedd == 28)
        {

            name2.SetText("Kira");
        }

        if (pressedd == 29)
        {
            
            name2.SetText("Diego");
        }
        if (pressedd == 30)
        {

            
        }
    }

    public void Start()
    {
        
    }


}
