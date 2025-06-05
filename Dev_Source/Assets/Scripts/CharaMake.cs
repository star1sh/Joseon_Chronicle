using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CharaMake : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI Cname;
    public GameObject inputField,InProgress, MaleCheck, FemaleCheck;
    public bool IsMale = true;
    public void HistoryButton()
    {
        Instantiate(InProgress, GameObject.Find("Canvas").transform);
        Cname = inputField.GetComponent<TextMeshProUGUI>();
    }
    public void GoBack()
    {
        SceneManager.LoadScene("Main");
    }
    public void MaleButton()
    {
        IsMale = true;
        MaleCheck.SetActive(true);
        FemaleCheck.SetActive(false);
    }
    public void FemaleButton()
    {
        IsMale = false;
        MaleCheck.SetActive(false);
        FemaleCheck.SetActive(true);
    }
    public void CreateButton()
    {
        if (Cname.text.Length > 0)
        {
            PlayerPrefs.SetString("PlayerName", Cname.text);
            PlayerPrefs.SetInt("IsMale", IsMale ? 1 : 0);
            SceneManager.LoadScene("Loading");
        }
    }
}
