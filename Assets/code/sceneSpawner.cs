using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneSpawner : MonoBehaviour
{
    public GameObject day1;
    public GameObject day2;
    public GameObject day3;
    // Start is called before the first frame update
    void Start()
    {
        SpawnOject(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnOject(int day)
    {
        if(day == 1){
            GameObject newObject = Instantiate(day1);
        }else if(day == 2){
            GameObject newObject = Instantiate(day2);
        }else if(day == 3){
            GameObject newObject = Instantiate(day3);
        }
    }
}
