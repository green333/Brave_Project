using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    [SerializeField]
    private GameObject[] players;    //仲間

    protected enum PLAYER
    {
        NORMAL   = 0x001,       //普通             1
        SPEEDER  = 0x002,       //スピード重視     2
        WEIGHTER = 0x004,       //重さ重視         3
        JUMPER   = 0x008,       //ジャンプ力       4
        SHORTER  = 0x010,       //近距離           5
        LONGER   = 0x040,       //遠距離           6
                                   //                 7                    
                                   //                 8
    }

    //[SerializeField]
    //protected PLAYER player;         //プレイヤーのステート


    //------------------------------------------

    //  初期化

    //------------------------------------------
    void Start () {
        Debug.Log("現在のキャラ数:" + Char_Button.char_num);

        //GameObject players = (GameObject)Resources.Load("Prefab/player");


        switch (Char_Button.char_select)
        {
            case (int)PLAYER.NORMAL:
                Instantiate(players[(int)PLAYER.NORMAL], new Vector3(0, 1.5f, 0), Quaternion.identity);
                break;

            case (int)PLAYER.SPEEDER:
                Instantiate(players[(int)PLAYER.SPEEDER], new Vector3(0, 1.5f, 0), Quaternion.identity);
                break;

            case (int)PLAYER.WEIGHTER:
                Instantiate(players[(int)PLAYER.WEIGHTER], new Vector3(0, 1.5f, 0), Quaternion.identity);
                break;

            case (int)PLAYER.JUMPER:
                Instantiate(players[(int)PLAYER.LONGER], new Vector3(0, 1.5f, 0), Quaternion.identity);
                break;

            case (int)PLAYER.SHORTER:
                Instantiate(players[(int)PLAYER.SHORTER], new Vector3(0, 1.5f, 0), Quaternion.identity);
                break;

            case (int)PLAYER.LONGER:
                Instantiate(players[(int)PLAYER.LONGER], new Vector3(0, 1.5f, 0), Quaternion.identity);
                break;
        }


        ////------------------
        ////  ノーマル
        //if(Char_Button.char_select == 1)
        //{
        //    Instantiate(players[0], new Vector3(0, 1.5f, 0), Quaternion.identity);
        //}

        ////------------------
        ////  ノーマル
        //if (Char_Button.char_select == 2)
        //{
        //    Instantiate(players[1], new Vector3(0, 1.5f, 0), Quaternion.identity);
        //}

        ////------------------
        ////  ノーマル
        //if (Char_Button.char_select == 3)
        //{
        //    Instantiate(players[0], new Vector3(0, 1.5f, 0), Quaternion.identity);
        //    Instantiate(players[1], new Vector3(0, 1.5f, 0), Quaternion.identity);
        //}

        ////------------------
        ////  ノーマル
        //if (Char_Button.char_select == 4)
        //{
        //    Instantiate(players[3], new Vector3(0, 1.5f, 0), Quaternion.identity);
        //}




        //for (int i = 0; i < Button_Act.char_num; i++)
        //{
        //    Instantiate(players[i], new Vector3(0, 1.0f, 0), Quaternion.identity);
        //}

    }


    //------------------------------------------

    //  更新

    //------------------------------------------
    void Update () {
	
	}
}
