using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
    public GameObject InProgress;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void InProgressButton()
    {
        Instantiate(InProgress, GameObject.Find("Canvas").transform);
    }
    public void QuitButton()
    {
            Application.Quit(); // Quit the application
    }
    public void CharaMakeButton()
    {
        SceneManager.LoadScene("CharaMake");
    }
}
