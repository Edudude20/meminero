using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskSave : MonoBehaviour {

    public string theText;
    public GameObject ourTask;
    public GameObject placeHolder;

    void Start() {
        theText = PlayerPrefs.GetString("TaskContents");
        placeHolder.GetComponent<InputField>().text = theText;
    }

    public void SaveTask()
    {
        theText = ourTask.GetComponent<Text>().text;
        PlayerPrefs.SetString("TaskContents", theText);
    }
}