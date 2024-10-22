using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;
using UnityEngine.UI;


public class CambioPensamiento : MonoBehaviour
{
    [SerializeField] GameObject objet1;
    [SerializeField] GameObject objet2;

    public void cisitis()
    {
        objet1.SetActive(true);
    }

    public void Deactivate()
    {
        objet2.SetActive(false);
    }
}
