using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public int itemsClicked;
    public DialogueManager dialogueManager;
    public Button humanButton;

    public void Start(){
        dialogueManager = FindObjectOfType<DialogueManager>();
        itemsClicked = dialogueManager.clicked;
    }

    public void Update(){
        if(itemsClicked == 4){
            Debug.Log("yay");
            humanButton.interactable = true;
            Debug.Log(humanButton.IsInteractable());
        }
    }

    public void TriggerDialogue(){
        itemsClicked += 1;
        Debug.Log(itemsClicked);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
