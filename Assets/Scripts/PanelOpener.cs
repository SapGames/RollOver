using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject MainPanel;

    public void OpenPanel () 
    {
        Panel.SetActive(true);
        if(Panel == true) 
        {
            MainPanel.SetActive(false);
        }
    }
}
