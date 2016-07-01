using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bottun : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
  
     
}
    public void RetryButton()
    {
        Debug.Log("Retry");
        SceneManager.LoadScene("Test3");
    }

    public void ExitButton()
    {
        Debug.Log("Exit");
        SceneManager.LoadScene("op");
    }
}
