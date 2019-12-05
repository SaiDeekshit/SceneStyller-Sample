using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateToolkit : MonoBehaviour
{
    public GameObject prefab;    //This is our prefab object that will be exposed in inspector

    public int numberToCreate;    // number of objects to create. Expand in inspector

    public InputField NameofToolkit;
    
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            Debug.Log("current name is : " + Name);
            name = value;
            Debug.Log("new name is : " + Name);
        }
    }

    private GameObject _currentSelectedToolkit;
    public GameObject currentSelectedToolkit
    {
        get    
        {
            return _currentSelectedToolkit;
        }
        set
        {
            if(currentSelectedToolkit != null)
                Deselect(currentSelectedToolkit);
            _currentSelectedToolkit = value;
            Select(currentSelectedToolkit);
        }
    }

    void Start(){
        PlayerPrefs.SetInt("ToolkitCount",0);
       numberToCreate = PlayerPrefs.GetInt("ToolkitCount");

       name = "Sai Deeskhit";
       Debug.Log(Name);
    }

    public void CreateToolkit()
    {
        numberToCreate = PlayerPrefs.GetInt("ToolkitCount") + 1;
        PlayerPrefs.SetInt("ToolkitCount",numberToCreate);
        Populate();
    }

   
    void Populate(){
        GameObject newObj;  // Create GameObject instance

        // for(int i = 0; i < numberToCreate; i++){
            newObj = (GameObject)Instantiate(prefab,transform);      //Create new instances of our prefab until we 've created as many as we specified
            newObj.GetComponent<RefernceToolkit>().SetToolkitName(NameofToolkit.text);
            // newObj.gameObject.transform.GetChild(0).GetChild(0).gameObject.GetComponent<Text>().text = NameofToolkit.text;
            // newObj.gameObject.transform.GetChild(1).GetChild(0).gameObject.GetComponent<Text>().text = NameofToolkit.text;
            // LobbyEvents.RaiseOnCreateButtonClick(NameofToolkit.text);
            NameofToolkit.text = "";
            
            // newObj.GetComponent<Image>().color = Random.ColorHSV();   // Randomize the color of our image
        // }

    }

    void Deselect(GameObject toolkit)
    {
        // logic to deselect the toolkit
    }

    void Select(GameObject toolkit)
    {
        // logic to select the toolkit
    }
}
