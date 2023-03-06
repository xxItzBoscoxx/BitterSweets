using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class itemInteracted : MonoBehaviour
{
    public bool itemClicked;
    public string itemName;
    // Start is called before the first frame update
    void Start()
    {
        itemClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver(){
        Debug.Log("here");
        if (Input.GetMouseButtonDown(0)) {
            itemName = gameObject.tag;
            itemClicked = true;
        }
    }
}
