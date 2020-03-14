using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteChange : MonoBehaviour
{
    public float pressed;
    public GameObject player;
    public SpriteRenderer emoted;
    public GameObject button;
    public GameObject Secret;
    public GameObject ChooseYourDestiny;
   
    public List<Sprite> myList = new List<Sprite>();

    // Start is called before the first frame update
    public void clicked()
    {
        pressed++;
    }

    // Update is called once per frame

    void Update()
    {
        if(pressed == 3) {
            GetComponent<SpriteRenderer>().sprite = myList[0];
            emoted.sprite = myList[0];
        }
        if (pressed == 4)
        {
            GetComponent<SpriteRenderer>().sprite = myList[1];
            emoted.sprite = myList[1];
        }
        if (pressed == 7)
        {
            GetComponent<SpriteRenderer>().sprite = myList[2];
            emoted.sprite = myList[2];
        }
        if (pressed == 10)
        {
            player.SetActive(false);
            button.SetActive(false);
            ChooseYourDestiny.SetActive(true);
            Secret.SetActive(true);
        }
    }

    public void Start()
    {
        
    }


}
