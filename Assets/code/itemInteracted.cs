using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class itemInteracted : MonoBehaviour
{
    public bool itemClicked;
    public DialogueTrigger dialogueTrigger;
    public string itemName;
    // Start is called before the first frame update
    void Start()
    {
        itemClicked = false;
    }

    void OnMouseOver(){
        Debug.Log("here");
        if (Input.GetMouseButtonDown(0)) {
            itemName = gameObject.tag;
            itemClicked = true;
            dialogueTrigger.TriggerDialogue();
        }
    }

    private Color startcolor;
     void OnMouseEnter()
     {
         startcolor = GetComponent<Renderer>().material.color;
         GetComponent<Renderer>().material.color = Color.red;
         mouseControl.instance.Clickable();

     }
     void OnMouseExit()
     {
         GetComponent<Renderer>().material.color = startcolor;
         mouseControl.instance.Default();
     }
}
