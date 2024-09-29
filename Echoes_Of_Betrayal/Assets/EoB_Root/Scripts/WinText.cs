using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinText : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;

    private void Start()
    {
        winText.SetActive(false);
    }

    private void Update()
    {
        if (Mirror.locked) 
        {
            winText.SetActive(true);
        }
    }
}
