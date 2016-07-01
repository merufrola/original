using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Replay : MonoBehaviour
{
    public Text time; 
    public static float bestscore = 999;
    public static string scoretext;
    public static string key = "SaveScore";
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time.text = Unitychan.stoptime.ToString("f2"); 

        if(bestscore >= Unitychan.stoptime)
        {
            bestscore = Unitychan.stoptime;
            Save();
        }

      
    }

    void Save()
    {
        scoretext = bestscore.ToString("f2");
        PlayerPrefs.SetString(key, scoretext);
    }
}
