using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    public GameObject ToolkitCapture_Template;    //Toolkit & Capture Template
    string CurrentPage = "";                           //CurrentPage (Template)


    public GameObject Login_Panel;                //Login & SignUp Panel
    public GameObject SingUp_Panel;

    public GameObject AccountCreated_Panel;       //After Account Creating Panel

    public Text EmailLogin_Text;                 //Email validation Text
    public Text EmailSignUp_Text;

    public GameObject GreyOutButtons;            //GreyOut Buttons at Toolkit
    
    public GameObject BackButton;
    public GameObject SaveButton;

    public GameObject Toolkit1_Grey,Toolkit2_Grey,Toolkit3_Grey,Toolkit4_Grey;  //List of Toolkit Greyout

    public GameObject Orient_Buttons2,Orient_Buttons3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToSignUpPanel(){              //for signup button
    SingUp_Panel.SetActive(true);
    Login_Panel.SetActive(false);
    }
    public void GoToLoginPanel(){              //for login button
    Login_Panel.SetActive(true);
    SingUp_Panel.SetActive(false);
    }
    public void AccountCreate_Open(){           //for Open Account created Panel
       if(EmailValidate.IsEmail(EmailSignUp_Text.text)){
        AccountCreated_Panel.SetActive(true);
       }
    }
    public void AfterLogin(){                   //for loginbutton at login panel
        if(EmailValidate.IsEmail(EmailLogin_Text.text)){
        ToolkitCapture_Template.SetActive(true);
        CurrentPage = "Toolkit";
        CurrentObjects();
       }
    }

    public void Toolkit1(){                         ///Selection of Toolkit
      CurrentToolkit("one");
    }
    public void Toolkit2(){
      CurrentToolkit("two");
    }
    public void Toolkit3(){
      CurrentToolkit("three");
    }
    public void Toolkit4(){
      CurrentToolkit("four");
    }
    void CurrentToolkit(string number){
        GreyOutButtons.SetActive(false);
        switch (number)
        {
            case "one":
            Toolkit1_Grey.SetActive(false);
            Toolkit2_Grey.SetActive(true);
            Toolkit3_Grey.SetActive(true);
            Toolkit4_Grey.SetActive(true);
            break;

            case "two":
            Toolkit1_Grey.SetActive(true);
            Toolkit2_Grey.SetActive(false);
            Toolkit3_Grey.SetActive(true);
            Toolkit4_Grey.SetActive(true);
            break;

            case "three":
            Toolkit1_Grey.SetActive(true);
            Toolkit2_Grey.SetActive(true);
            Toolkit3_Grey.SetActive(false);
            Toolkit4_Grey.SetActive(true);
            break;

            case "four":
            Toolkit1_Grey.SetActive(true);
            Toolkit2_Grey.SetActive(true);
            Toolkit3_Grey.SetActive(true);
            Toolkit4_Grey.SetActive(false);
            break;
            
      
        }
    }

    public void Deselect_Toolkit(){
            Toolkit1_Grey.SetActive(true);
            Toolkit2_Grey.SetActive(true);
            Toolkit3_Grey.SetActive(true);
            Toolkit4_Grey.SetActive(true);
            GreyOutButtons.SetActive(true);
    }


    void CurrentObjects(){
        switch (CurrentPage)
        {
            case "Toolkit":
            BackButton.SetActive(false);
            SaveButton.SetActive(false);
            break;
            
            // default:
        }
    }

}
