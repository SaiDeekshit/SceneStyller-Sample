using System.Runtime.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefernceToolkit : MonoBehaviour
{
    public Text nameToolkitSelected;
    public Text nameToolkitUnSelected;
    public Image selectedImage;
    public Image unselectedImage;
    // Start is called before the first frame update

    // void OnEnable() {
    //     LobbyEvents.onCreateButtonClick += SetToolkitName;
    // }
    // void OnDisable() {
    //     LobbyEvents.onCreateButtonClick -= SetToolkitName;
    // }
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    void Awake() 
    {
        DeselectThis();    
    }

    public void SelectThis()
    {
        selectedImage.gameObject.SetActive(true);
        unselectedImage.gameObject.SetActive(false);
    }

    public void DeselectThis()
    {
        selectedImage.gameObject.SetActive(false);
        unselectedImage.gameObject.SetActive(true);
    }

    void TaskOnClick()
    {
        LobbyEvents.RaiseOnToolkitSelected(this);
    }
    public void SetToolkitName(string NameToolkit){

        nameToolkitSelected.text = NameToolkit;
        nameToolkitUnSelected.text = NameToolkit;
    }
}
