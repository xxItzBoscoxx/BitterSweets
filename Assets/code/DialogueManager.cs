using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public int clicked;
    public bool dialogueOpen;
    public Animator animator;
    private Queue<string> sentences;
    private Queue<string> names;
    // Start is called before the first frame update
    void Start()
    {
        dialogueOpen = false;
        names = new Queue<string>();
        sentences = new Queue<string>();
        clicked = 0;
    }

    public void StartDialogue(Dialogue dialogue){
        dialogueOpen = true;
        //nameText.text = dialogue.name;
        animator.SetBool("IsOpen", true);

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
            clicked += 1;
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
        dialogueOpen = false;
        animator.SetBool("IsOpen", false);
    }
}
