using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyEvents
{
    public delegate void OnToolkitSelected(RefernceToolkit toolkit);
    public static event OnToolkitSelected onToolkitSelected;
    public delegate void OnCreateButtonClick(string NameOfToolkit);
    public static event OnCreateButtonClick onCreateButtonClick;

    public static void RaiseOnToolkitSelected(RefernceToolkit toolkit)
    {
        if(onToolkitSelected != null)
            onToolkitSelected(toolkit);
    }
    public static void RaiseOnCreateButtonClick(string NameOfToolkit)
    {
        if(onCreateButtonClick != null)
            onCreateButtonClick(NameOfToolkit);
    }
}
