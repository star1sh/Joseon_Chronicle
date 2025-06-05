using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public DialogStorage DialogSets;
    public GameObject CantGo;
    public TextMeshProUGUI TextBox;
    DialogList DialogListOn;
    void Start()
    {
        TextBox = GameObject.Find("Story").GetComponent<TextMeshProUGUI>();
        DialogSets = GameObject.Find("DialogSet").GetComponent<DialogStorage>();
        DialogListOn = GameObject.Find("DialogListOn").GetComponent<DialogList>();
    }
    public void SetRandomDialog()
    {
        List<string> keys = new List<string>();
        foreach (var key in DialogListOn.IsDialogProceeded.Keys)
        {
            if (!DialogListOn.IsDialogProceeded[key])
            {
                keys.Add(key);
            }
        }
        int i = Random.Range(0, keys.Count);
        string[] dialogSet = DialogSets.DialogSets[keys[i]];
        TextBox.GetComponent<Dialog>().SetDialogSet(dialogSet);
        DialogListOn.IsDialogProceeded[keys[i]] = true;

    }
    public void GoInGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void CantGoButton()
    {
        GameObject DO = Instantiate(CantGo, GameObject.Find("Canvas").transform);
    }
    public void CantGoButton2()
    {
        Destroy(transform.parent.gameObject);
    }
    public void StartDialogButton()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Startdialog2);
        Destroy(transform.parent.parent.gameObject);
    }
    public void StartDialogButton2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Startdialog3);
        Destroy(transform.parent.parent.gameObject);
    }
    public void StartDialogButton3()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Startdialog4);
        Destroy(transform.parent.parent.gameObject);
    }
    public void StartDialogButton4()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Startdialog5);
        Destroy(transform.parent.parent.gameObject);
    }
    public void StartDialogButton5()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Main1_1);
        DialogListOn.IsDialogProceeded["Main1_1"] = true;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main1_1Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Main1_1_1);
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp - 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main1_1Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Main1_1_2);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main1_1_1Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Main1_1_1_1);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main1_1_2Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main1_1_1_1Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.Main1_1_1_2);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main1_1_1_2Button()
    {
        DialogListOn.IsDialogProceeded["Main2_1"] = false;
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Main2_1Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main2_1_1"]);
        DialogListOn.IsDialogProceeded["Main2_1"] = true;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main2_1Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main2_1_2"]);
        DialogListOn.IsDialogProceeded["Main2_1"] = true;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main2_1_1Button()
    {
        int i = Random.Range(0, 2);
        if (i == 0)
        {
            int temp = int.Parse(GameObject.Find("StrText").GetComponent<TextMeshProUGUI>().text);
            GameObject.Find("StrText").GetComponent<TextMeshProUGUI>().text = (temp + 1).ToString();
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main2_1_1_1"]);
        }
        else
        {
            GameObject.Find("HPBar").GetComponent<Image>().fillAmount = 0.2f;
            GameObject.Find("MPBar").GetComponent<Image>().fillAmount = 0.2f;
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main2_1_1_2"]);
        }
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main2_1_1_1Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main2_2"]);

        Destroy(transform.parent.parent.gameObject);
    }
    public void Main2_1_1_2Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main2_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main2_1_2Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main2_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main2_2Button()
    {
        DialogListOn.IsDialogProceeded["Main3_1"] = false;
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Main3_1Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main3_1_1"]);
        DialogListOn.IsDialogProceeded["Main3_1"] = true;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_1Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main3_2_1"]);
        DialogListOn.IsDialogProceeded["Main3_1"] = true;
        GameObject.Find("HPBar").GetComponent<Image>().fillAmount = GameObject.Find("HPBar").GetComponent<Image>().fillAmount + 0.4f;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_1_1Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main3_1_1_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_1_1_1Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main3_1_1_1_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_1_1_1Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main3_1_1_1_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_1_1_1_1Button()
    {
        DialogListOn.IsDialogProceeded["Main4_1"] = false;
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_1_1_1_2Button()
    {
        DialogListOn.IsDialogProceeded["Main4_1"] = false;
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_2_1Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main3_2_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main3_2_2Button()
    {
        DialogListOn.IsDialogProceeded["Main4_1"] = false;
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Main4_1Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main4_2"]);
        DialogListOn.IsDialogProceeded["Main4_1"] = true;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main4_2Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main4_2_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main4_2Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main4_2_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main4_2_1Button()
    {
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp + 3).ToString();
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main4_2_2Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main4_2_2_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main4_2_2Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main4_2_2_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main4_2_2_1Button()
    {
        DialogListOn.IsDialogProceeded["Main5_1"] = false;
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main4_2_2_2Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Main5_1Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main5_1_1"]);
        DialogListOn.IsDialogProceeded["Main5_1"] = true;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main5_1Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main5_1_2"]);
        DialogListOn.IsDialogProceeded["Main5_1"] = true;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main5_1_1and2Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main5_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main5_2Button1()
    {
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp + 3).ToString();
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main5_2Button2()
    {
        DialogListOn.IsDialogProceeded["Main6_1"] = false;
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Main6_1Button()
    {
        DialogListOn.IsDialogProceeded["Main6_1"] = true;
        int i = Random.Range(0, 2);
        if (i == 0)
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main6_1_1"]);
        }
        else
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main6_1_2"]);
        }
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main6_1_1Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main6_1_2Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main6_2"]);
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp + 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main6_2Button()
    {
        int i = Random.Range(0, 2);
        if (i == 0)
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main6_2_1"]);
        }
        else
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main6_2_2"]);
        }
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main6_2_1Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main6_2_2Button()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Main6_3"]);
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp + 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Main6_3Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Sub1_1Button()
    {
        DialogListOn.IsDialogProceeded["Sub1_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub1_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2Button1()
    {
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        if (temp > 0)
        {
            GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp - 1).ToString();
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub1_2_1"]);
        }
        else
            CantGoButton();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub1_2_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2Button3()
    {
        int temp = int.Parse(GameObject.Find("StrText").GetComponent<TextMeshProUGUI>().text);
        if (temp > 2)
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub1_2_3"]);
        }
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2_1Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2_2Button()
    {
        int temp = Random.Range(0, 2);
        if (temp == 0)
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub1_2_2_1"]);
        }
        else
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub1_2_2_2"]);
        }
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2_2_1Button()
    {
        SetRandomDialog();
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp + 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2_2_2Button()
    {
        SetRandomDialog();
        GameObject.Find("HPBar").GetComponent<Image>().fillAmount = GameObject.Find("HPBar").GetComponent<Image>().fillAmount + 0.2f;
        GameObject.Find("MPBar").GetComponent<Image>().fillAmount = GameObject.Find("MPBar").GetComponent<Image>().fillAmount + 0.2f;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub1_2_3Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Sub2_1Button1()
    {
        DialogListOn.IsDialogProceeded["Sub2_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub2_1_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub2_1Button2()
    {
        DialogListOn.IsDialogProceeded["Sub2_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub2_1_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub2_1Button3()
    {
        DialogListOn.IsDialogProceeded["Sub2_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub2_1_3"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub2_1_1Button()
    {
        SetRandomDialog();
        GameObject.Find("HPBar").GetComponent<Image>().fillAmount = GameObject.Find("HPBar").GetComponent<Image>().fillAmount + 0.1f;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub2_1_2Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub2_1_3Button()
    {
        int temp = Random.Range(0, 2);
        if (temp == 0)
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub2_1_3_1"]);
        }
        else
        {
            TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub2_1_3_2"]);
        }
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub2_1_3_1Button()
    {
        SetRandomDialog();
        GameObject.Find("HPBar").GetComponent<Image>().fillAmount = GameObject.Find("HPBar").GetComponent<Image>().fillAmount - 0.2f;
        GameObject.Find("MPBar").GetComponent<Image>().fillAmount = GameObject.Find("MPBar").GetComponent<Image>().fillAmount - 0.2f;
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub2_1_3_2Button()
    {
        SetRandomDialog();
        GameObject.Find("HPBar").GetComponent<Image>().fillAmount = GameObject.Find("HPBar").GetComponent<Image>().fillAmount + 0.1f;
        GameObject.Find("MPBar").GetComponent<Image>().fillAmount = GameObject.Find("MPBar").GetComponent<Image>().fillAmount + 0.1f;
        Destroy(transform.parent.parent.gameObject);
    }

    public void Sub3_1Button1()
    {
        DialogListOn.IsDialogProceeded["Sub3_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub3_1_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub3_1Button2()
    {
        DialogListOn.IsDialogProceeded["Sub3_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub3_1_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub3_1_1Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub3_1_2Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub3_1_2_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub3_1_2Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub3_1_2_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub3_1_2_1Button()
    {
        SetRandomDialog();
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp + 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub3_1_2_2Button()
    {
        SetRandomDialog();
        int temp = int.Parse(GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text);
        if (temp > 0)
            GameObject.Find("GoldText").GetComponent<TextMeshProUGUI>().text = (temp - 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }

    public void Sub4_1Button1()
    {
        DialogListOn.IsDialogProceeded["Sub4_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub4_1_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub4_1Button2()
    {
        DialogListOn.IsDialogProceeded["Sub4_1"] = true;
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub4_1_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub4_1_1Button1()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub4_1_1_1"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub4_1_1Button2()
    {
        TextBox.GetComponent<Dialog>().SetDialogSet(DialogSets.DialogSets["Sub4_1_1_2"]);
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub4_1_2Button()
    {
        SetRandomDialog();
        int temp = int.Parse(GameObject.Find("LuckText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("LuckText").GetComponent<TextMeshProUGUI>().text = (temp - 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub4_1_1_1Button()
    {
        SetRandomDialog();
        int temp = int.Parse(GameObject.Find("LuckText").GetComponent<TextMeshProUGUI>().text);
        GameObject.Find("LuckText").GetComponent<TextMeshProUGUI>().text = (temp + 1).ToString();
        Destroy(transform.parent.parent.gameObject);
    }
    public void Sub4_1_1_2Button()
    {
        SetRandomDialog();
        Destroy(transform.parent.parent.gameObject);
    }
}
