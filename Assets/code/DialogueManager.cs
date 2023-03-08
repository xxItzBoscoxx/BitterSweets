using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    private Queue<string> names;
    // Start is called before the first frame update
    void Start()
    {
        names = new Queue<string>();
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue){

        //nameText.text = dialogue.name;

        names.Clear();
        sentences.Clear();

        foreach(string name in dialogue.names){
            names.Enqueue(name);
        }

        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if(sentences.Count == 0){
            EndDialogue();
            return;
        }

        string name = names.Dequeue();
        nameText.text = name;
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence){
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            yield return null;
        }

    }

    void EndDialogue(){
        
        Debug.Log("End of conversation");
    }
}
