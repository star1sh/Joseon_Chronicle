using UnityEngine;
using TMPro;

public class InGameLoad : MonoBehaviour
{
    public GameObject MaleImage, FemaleImage;
    public TextMeshProUGUI PlayerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isMale = PlayerPrefs.GetInt("IsMale", 1) == 1; // Default
        PlayerName.text = PlayerPrefs.GetString("PlayerName", "Player");
        if (isMale)
        {
            MaleImage.SetActive(true);
        }
        else
        {
            FemaleImage.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
