using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [System.Serializable]
    public class Dialogue
    {

        public string name;

        [TextArea(3, 10)]
        public string[] sentences;

    }
}
