using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public int itemsClicked;
    public DialogueManager dialogueManager;
    public GameObject human;

    public void Start(){
        human = GameObject.FindWithTag("Human");
        dialogueManager = FindObjectOfType<DialogueManager>();
        itemsClicked = dialogueManager.clicked;
    }

    public void Update(){
        
    }

    public void TriggerDialogue(){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
