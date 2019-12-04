using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public GameObject prefab;    //This is our prefab object that will be exposed in inspector

    public int numberToCreate;    // number of objects to create. Expand in inspector
    // Start is called before the first frame update
    void Start()
    {
        Populate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Populate(){
        GameObject newObj;  // Create GameObject instance

        for(int i =0; i < numberToCreate; i++){
            newObj = (GameObject)Instantiate(prefab,transform);      //Create new instances of our prefab until we 've created as many as we specified
            newObj.GetComponent<Image>().color = Random.ColorHSV();   // Randomize the color of our image
        }

    }
}

