using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Taquilla : MonoBehaviour
{

    public GameObject taquilla;

    private void Start()
    {
        taquilla.SetActive(false);
    }

    private void Update()
    {
        TAQUILLA();
    }

    void TAQUILLA()
    {
        if (GameManager.Instance.allCheckItems == true && GameManager.Instance.rickDialogueClose == true)
        {
            taquilla.SetActive(true);
            
        }
    }
}
