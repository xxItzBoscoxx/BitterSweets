using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class itemInteracted : MonoBehaviour
{
    public bool isInteractable;
    public bool isClicked;
    public bool oneClicked;
    public int clickables;
    public DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;
    public GameObject humanDude;
    public string itemName;
    // Start is called before the first frame update
    void Start()
    {
        oneClicked = false;
        isClicked = false;
        dialogueManager = FindObjectOfType<DialogueManager>();
        humanDude = GameObject.FindWithTag("Human");
        isInteractable = true;
        if(gameObject.tag == "Human"){
            isInteractable = false;
        }else{
            dialogueManager.clickables += 1;
            print(dialogueManager.clickables);
        }
    }

    void Update(){
        if(oneClicked && dialogueManager.clickables <= -1){
    
        }
    }

    void OnMouseOver(){
        if (Input.GetMouseButtonDown(0) && isInteractable && !dialogueManager.dialogueOpen) {
            oneClicked = true;
            itemName = gameObject.tag;
            dialogueManager.clickables -= 1;
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

     public bool IsInteractable(){
         return isInteractable;
     }
}
