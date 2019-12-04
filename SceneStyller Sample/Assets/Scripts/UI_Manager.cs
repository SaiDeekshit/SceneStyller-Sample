using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
   
    [Header("Templates & Panels")]
    public GameObject ToolkitCapture_Template;    //Toolkit & Capture Template
    public GameObject Capture_Template;
    string CurrentPage = "";                           //CurrentPage (Template)


    public GameObject Login_Panel;                //Login & SignUp Panel
    public GameObject SingUp_Panel;

    public GameObject AccountCreated_Panel;       //After Account Creating Panel

    public Text EmailLogin_Text;                 //Email validation Text
    public Text EmailSignUp_Text;

    public GameObject GreyOutButtons;            //GreyOut Buttons at Toolkit
    
    public GameObject BackButton;
    public GameObject SaveButton;

    // public GameObject Toolkit1_Grey,Toolkit2_Grey,Toolkit3_Grey,Toolkit4_Grey;  //List of Toolkit Greyout

    public GameObject Orient_Buttons2,Orient_Buttons3;

    public Animator Right_Panel,Left_Panel;

    [Space(10)]
    [Header("InputFields")]
    public InputField Email_Id;
    public InputField Password;
    public InputField Captcha1;
    public InputField FirstName;
    public InputField LastName;
    public InputField EnterEmail;
    public InputField EnterPassword;
    public InputField Captcha2;
    [Space(10)]
    [Header("Top Buttons")]
    public GameObject SaveLogo_Blue;           //Buttons for Save and Profile
    public GameObject SaveDropDown;
    public GameObject ProfileLogo;
    public GameObject ProfileDropDown;
    bool ProfileDropBl = true;
    public GameObject Setting_Panel;
    
    


    // Start is called before the first frame update
    void Start()
    {
        ToolkitCapture_Template.SetActive(false);
        Capture_Template.SetActive(false);
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
        Email_Id.text = "";
        Password.text = "";
        Captcha1.text = "";
        FirstName.text = "";
        LastName.text = "";
        EnterEmail.text = "";
        EnterPassword.text = "";
        Captcha2.text = "";
        CurrentObjects();
       }
    }

    public void OpenDropSave(){                     //Open and Close Drop Down of Save
      ProfileDropDown.SetActive(false);
      SaveDropDown.SetActive(true);
      SaveLogo_Blue.SetActive(false);
    }
    public void CloseDropSave(){
      SaveDropDown.SetActive(false);
      SaveLogo_Blue.SetActive(true);
    }

    public void OpenSettingPanel(){
      if(CurrentPage == "Capture"){
      Setting_Panel.SetActive(true);
       SaveDropDown.SetActive(false);
       ProfileDropDown.SetActive(false);
      }
    }

    public void OpenDropProfile(){            //OPen and Close Drop profile
      if(ProfileDropBl){
      SaveDropDown.SetActive(false);
      ProfileDropDown.SetActive(true);
      }else{
        ProfileDropDown.SetActive(false);
      }
      ProfileDropBl = !ProfileDropBl;
    }

    public void SignOut(){                      //Signout
      switch(CurrentPage){
        case "Toolkit":
        ToolkitCapture_Template.SetActive(false);
        GreyOutButtons.SetActive(true);
        break;
        case "Capture":
        ToolkitCapture_Template.SetActive(false);
        Capture_Template.SetActive(false);
        GreyOutButtons.SetActive(true);
        break;
        
      }
    }
    
    public void GotoCapture_Template(){          //For Design Button
      CurrentPage = "Capture";
    }
    

    // public void Toolkit1(){                         ///Selection of Toolkit
    //   CurrentToolkit("one");
    // }
    // public void Toolkit2(){
    //   CurrentToolkit("two");
    // }
    // public void Toolkit3(){
    //   CurrentToolkit("three");
    // }
    // public void Toolkit4(){
    //   CurrentToolkit("four");
    // }
    // void CurrentToolkit(string number){
    //     GreyOutButtons.SetActive(false);
    //     switch (number)
    //     {
    //         case "one":
    //         Toolkit1_Grey.SetActive(false);
    //         Toolkit2_Grey.SetActive(true);
    //         Toolkit3_Grey.SetActive(true);
    //         Toolkit4_Grey.SetActive(true);
    //         break;

    //         case "two":
    //         Toolkit1_Grey.SetActive(true);
    //         Toolkit2_Grey.SetActive(false);
    //         Toolkit3_Grey.SetActive(true);
    //         Toolkit4_Grey.SetActive(true);
    //         break;

    //         case "three":
    //         Toolkit1_Grey.SetActive(true);
    //         Toolkit2_Grey.SetActive(true);
    //         Toolkit3_Grey.SetActive(false);
    //         Toolkit4_Grey.SetActive(true);
    //         break;

    //         case "four":
    //         Toolkit1_Grey.SetActive(true);
    //         Toolkit2_Grey.SetActive(true);
    //         Toolkit3_Grey.SetActive(true);
    //         Toolkit4_Grey.SetActive(false);
    //         break;
            
      
    //     }
    // }

    // public void Deselect_Toolkit(){
    //         Toolkit1_Grey.SetActive(true);
    //         Toolkit2_Grey.SetActive(true);
    //         Toolkit3_Grey.SetActive(true);
    //         Toolkit4_Grey.SetActive(true);
    //         GreyOutButtons.SetActive(true);
    // }

    
  public void InfoForward_Anim(){                                 // For Right side panels Info, lighting and Camera
    Right_Panel.SetBool("InfoPanel",true);
  }
  public void InfoBackward_Anim(){
    Right_Panel.SetBool("InfoPanel",false);
  }
  public void LightForward_Anim(){
    Right_Panel.SetBool("LightPanel",true);
  }
  public void LightBackward_Anim(){
    Right_Panel.SetBool("LightPanel",false);
  }
  public void CameraForward_Anim(){
    Right_Panel.SetBool("CameraPanel",true);
  }
  public void CameraBackward_Anim(){
    Right_Panel.SetBool("CameraPanel",false);
  }
  
  public void AddForward_Anim(){
    Left_Panel.SetBool("AddBool",true);
  }
  public void AddBackward_Anim(){
    Left_Panel.SetBool("AddBool",false);
  }
  public void InventoryForward_Anim(){
    Left_Panel.SetBool("InventoryBool",true);
  }
  public void InventoryBackward_Anim(){
    Left_Panel.SetBool("InventoryBool",false);
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
