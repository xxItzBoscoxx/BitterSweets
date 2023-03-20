using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class itemInteracted : MonoBehaviour
{
    public bool isInteractable;
    public DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;
    public string itemName;
    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
        isInteractable = true;
        if(gameObject.tag == "Human"){
            isInteractable = false;
        }
    }

    void OnMouseOver(){
        if (Input.GetMouseButtonDown(0) && isInteractable && !dialogueManager.dialogueOpen) {
            itemName = gameObject.tag;
            dialogueTrigger.TriggerDialogue();
            isInteractable = false;
            GetComponent<Renderer>().material.color = startcolor;
            mouseControl.instance.Default();
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
         if(isInteractable && !dialogueManager.dialogueOpen){
            GetComponent<Renderer>().material.color = startcolor;
            mouseControl.instance.Default();
         }
     }
}
