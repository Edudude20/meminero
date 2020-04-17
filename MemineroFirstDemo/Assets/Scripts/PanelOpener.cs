using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if (Panel != null)

        {
            var newPanel = Instantiate(Panel, new Vector3(1, 1, 1), Quaternion.identity);

            newPanel.transform.parent = gameObject.transform.Find("Canvas/Base Image");


        }
           
    }

}
