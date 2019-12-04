using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolkitManager : MonoBehaviour
{
    public UI_Manager ui_Manager;
    public ToolkitManager Tkm;
    public GameObject _currentSelectedToolkit = null;
    public GameObject currentSelectedToolkit
    {
        get    
        {
            return _currentSelectedToolkit;
        }
        set
        {
            if(currentSelectedToolkit != null)
                DeSelectToolkit(currentSelectedToolkit);
            _currentSelectedToolkit = value;
            SelectToolkit(currentSelectedToolkit);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       ui_Manager = GameObject.Find("UIManager").GetComponent<UI_Manager>();
       Tkm = GameObject.Find("UIManager").GetComponent<ToolkitManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectToolkit(GameObject Toolkit){
    //   Debug.Log("SelectToolkit");
      _currentSelectedToolkit.SetActive(false);
      ui_Manager.GreyOutButtons.SetActive(false);
    }
    public void DeSelectToolkit(GameObject Toolkit){
        // Debug.Log("DeSelectToolkit");
        _currentSelectedToolkit.SetActive(true);
        ui_Manager.GreyOutButtons.SetActive(true);
    }
    public void DeSelectAll(){
        Tkm.currentSelectedToolkit = null;
    }
}
