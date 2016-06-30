using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public Text score;

    // Use this for initialization
    void Start()
    {
        score.text = PlayerPrefs.GetString(Replay.key, "no record");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartButton()
    {
        SceneManager.LoadScene("Test3");
    }
}
