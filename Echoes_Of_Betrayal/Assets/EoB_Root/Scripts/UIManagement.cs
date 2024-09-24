using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.AudioSettings;

public class UIManagement : MonoBehaviour
{

    GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void PEREZOSO()
    {
        gameManager.perezoso = true;
    }

    public void VASO()
    {
        gameManager.vaso = true;
    }

    public void LLAVES()
    {
        gameManager.llaves = true;
    }

    public void MOVIL()
    {
        gameManager.movil = true;
    }
}
