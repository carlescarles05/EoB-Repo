using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cinematics : MonoBehaviour
{



    [Header("Cinematicas")]
    [SerializeField] GameObject cineStart;
    [SerializeField] GameObject cineFinish;
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartSkip()
    {
        cineStart.SetActive(false);
    }
    public void FinishSkip()
    {
        cineFinish.SetActive(true);
    }
}

