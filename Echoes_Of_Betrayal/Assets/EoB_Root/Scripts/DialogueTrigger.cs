using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager manager;

    public GameObject button;
    public GameObject continueButton;

    private void Start()
    {
        manager = GetComponent<DialogueManager>();
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        button.SetActive(false);
        continueButton.SetActive(true);

    }

    public void TriggerReset()
    {
        button.SetActive(true);
        continueButton.SetActive(false);
    }

}
