using UnityEngine;
using System.Collections;


public class Button_Act : MonoBehaviour {

    [SerializeField]
    private bool clickflg;  //選択されたどうか

    [SerializeField]
    private int own_number;      //キャラ自身の番号

    public static int char_select;    //何体選択されてるか（ビット）

    public static int char_num = 0;     //現在の選択しているキャラ数;


    void Start () {
	
	}
	
	void Update () {


	}


    //-----------------------------------------------

    //  クリックされた時の処理

    //-----------------------------------------------
    public void OnClick()
    {
        clickflg = !clickflg;


        if (clickflg)
        {
            char_select += own_number;    //フラグ立てる
            char_num++;
        }
        else
        {
            char_select -= own_number;    //フラグ降ろす
            char_num--;
        }
        Debug.Log("現在のビット:" + char_select);

        Debug.Log("キャラ数:" + char_num);

    }
}
