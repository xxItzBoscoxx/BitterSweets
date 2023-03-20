using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class itemInteracted : MonoBehaviour
{
    public bool itemClicked;
    public bool isInteractable;
    public DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;
    public string itemName;
    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
        itemClicked = false;
        isInteractable = true;
    }

    void OnMouseOver(){
        if (Input.GetMouseButtonDown(0) && !itemClicked && !dialogueManager.dialogueOpen) {
            itemName = gameObject.tag;
            itemClicked = true;
            dialogueTrigger.TriggerDialogue();
            isInteractable = false;
        }
    }

    private Color startcolor;
     void OnMouseEnter()
     {
         if(isInteractable && !dialogueManager.dialogueOpen){
            startcolor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.red;
            mouseControl.instance.Clickable();
         }

     }
     void OnMouseExit()
     {
         GetComponent<Renderer>().material.color = startcolor;
         mouseControl.instance.Default();
     }
}
