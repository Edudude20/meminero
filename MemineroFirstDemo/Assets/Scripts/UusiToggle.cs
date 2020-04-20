using UnityEngine;
using System.Collections;

public class UusiToggle : MonoBehaviour
{
    // manually add prefab in Unity Editor
    public GameObject Toggle;
    private GameObject s1Button;

    // manually add in Unity Editor
    public GameObject ButtonListContent;


    public void DoStart()
    {
        if (Toggle != null)
        {
            s1Button = Instantiate(Toggle);
            //Sets "ChoiceButtonHolder" as the new parent of the s1Button.
            s1Button.transform.SetParent(ButtonListContent.transform, false);
        }
        
    }
}