using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] GameObject[] sprites;

    public void PrimeraQuest()
    {
        sprites[0].SetActive(false);
        sprites[1].SetActive(true);
    }
    public void SegundaQuest()
    {
        sprites[0].SetActive(false);
        sprites[2].SetActive(true);
    }

}
