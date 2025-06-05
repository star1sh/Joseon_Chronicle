using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NextButton : MonoBehaviour
{
    public DialogStorage DialogSets;
    public TextMeshProUGUI TextBox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextBox = GameObject.Find("Story").GetComponent<TextMeshProUGUI>();
        DialogSets = GameObject.Find("DialogSet").GetComponent<DialogStorage>();
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Startdialog);
    }
    public void GoNext()
    {
        TextBox.GetComponent<Dialog>().StartOutPutText();
    }
}
