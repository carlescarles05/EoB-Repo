using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;
using UnityEngine.UI;


public class InicionMenu : MonoBehaviour
{
    [SerializeField] GameObject objet;


    public void cisitis()
    {
        objet.SetActive(true);
    }
}
