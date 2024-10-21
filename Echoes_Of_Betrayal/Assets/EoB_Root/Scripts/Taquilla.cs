using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taquilla : MonoBehaviour
{

    public GameObject taquilla;

    private void Start()
    {
        taquilla.SetActive(false);
    }

    private void Update()
    {
        if (GameManager.Instance.allCheckItems == true)
        {
            taquilla.SetActive(true);
        }
    }
}
