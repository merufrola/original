using UnityEngine;
using System.Collections;

public class GUIskin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        bool push;

        //---------------------------------------------------------------
        //色や文字の大きさの指定がない、ごく普通のボタン。実装が一番簡単
        //---------------------------------------------------------------
        // ボタンを表示する
        // X位置　Y位置 幅　高さ　ボタン名を書く
        push = GUI.Button(new Rect(129, 51, 100, 50), "Start");
        if (push == true)
        {
            //ボタン押された状態
            Debug.Log("普通のボタン押された");
        }
    }

}
