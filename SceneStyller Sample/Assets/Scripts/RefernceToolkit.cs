using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefernceToolkit : MonoBehaviour
{
    public ToolkitManager Tkm;
    // public UI_Manager ui_Manager;
    public Text nameToolkit;
    private Button myselfButton;
    // Start is called before the first frame update
    void Start()
    {
        myselfButton = GetComponent<Button>();
        myselfButton.onClick.AddListener(TaskOnClick);
        Tkm = GameObject.Find("UIManager").GetComponent<ToolkitManager>();
        // ui_Manager = GameObject.Find("UIManager").GetComponent<UI_Manager>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
        Tkm.currentSelectedToolkit = this.gameObject;
        Debug.Log("TaskOnClick");
    }
    
}
