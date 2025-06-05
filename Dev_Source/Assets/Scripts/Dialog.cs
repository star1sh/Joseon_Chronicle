using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI TMP;
    bool isDialog = false;
    public DialogStorage dialogStorage;
    public string[] dialogSet;
    public List<GameObject> dialogObjects = new List<GameObject>();
    GameObject Canvas;

    public int dialogIndex = 0;
    void Awake()
    {
        TMP = GetComponent<TextMeshProUGUI>();
        Canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetDialogSet(string[] dialogSet)
    {
        this.dialogSet = dialogSet;
        dialogIndex = 0;
        StartOutPutText();
    }
    public void StartOutPutText()
    {
        string[] temp = dialogSet[dialogIndex].Split('|');
        if (!isDialog)
        {
            isDialog = true;
            StartCoroutine(OutPutText(temp[0], temp[1]));
        }
        else if (isDialog)
        {
            StopAllCoroutines();
            TMP.text = temp[0];
            if(temp[1]!="X")
                MakeDialogObject(temp[1]);
            dialogIndex++;
            isDialog = false;
        }
    }
    IEnumerator OutPutText(string message, string button)
    {
        string temp = "";
        for (int i = 0; i < message.Length; i++)
        {
            temp += message[i];
            TMP.text = temp;
            yield return new WaitForSeconds(0.05f);
        }
        TMP.text = message;
        dialogIndex++;
        isDialog = false;
        if(button!="X")
                MakeDialogObject(button);
    }
    void MakeDialogObject(string text)
    {
        Debug.Log(text);
        GameObject DO = Instantiate(dialogObjects.Find(obj => obj.name == text), Canvas.transform);
    }
}
