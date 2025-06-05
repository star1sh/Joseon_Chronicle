using UnityEngine;

public class Buttons2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Dic;
    public GameObject Inven;
    public void DicButton()
    {
        GameObject DO = Instantiate(Dic, GameObject.Find("Canvas").transform);
    }
    public void InvenButton()
    {
        GameObject IO = Instantiate(Inven, GameObject.Find("Canvas").transform);
    }
}
