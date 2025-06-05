using System.Collections;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public GameObject LoadingImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(GoInGame());
    }

    // Update is called once per frame
    void Update()
    {
        LoadingImage.transform.Rotate(new Vector3(0, 0, -90*Time.deltaTime), Space.Self);
    }
    IEnumerator GoInGame()
    {
        yield return new WaitForSeconds(3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("InGame");
    }
}
