using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuchillo : MonoBehaviour
{

    public Image myImage;
    public Button myButton;


    void Start()
    {
        myImage = GetComponent<Image>();
        myButton = GetComponent<Button>();
        myImage.enabled = false;
        myButton.interactable = false;
        
    }

    void Update()
    {
        if (GameManager.Instance.allCheckItems == true && GameManager.Instance.rickDialogueClose == true)
                {
            myImage.enabled = true;
            myButton.interactable = true;
        }
    }
}
