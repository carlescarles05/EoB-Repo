using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuchillo : MonoBehaviour
{

    public Image myImage;
    public Button myButton;

    //  public GameObject casilla;



    // Start is called before the first frame update
    void Start()
    {
        myImage = GetComponent<Image>();
        myButton = GetComponent<Button>();
        myImage.enabled = false;
        myButton.interactable = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.allCheck == true)
                {
            myImage.enabled = true;
            myButton.interactable = true;
        }
    }
}
