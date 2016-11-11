using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    [SerializeField]
    private GameObject[] players;    //仲間

    protected enum PLAYER
    {
        NORMAL   = 00000001,       //普通             1
        SPEEDER  = 00000010,       //スピード重視     2
        WEIGHTER = 00000100,       //重さ重視         3
        JUMPER   = 00001000,       //ジャンプ力       4
        SHORTER  = 00010000,       //近距離           5
        LONGER   = 00100000,       //遠距離           6
                                   //                 7                    
                                   //                 8
    }

    [SerializeField]
    protected PLAYER player;         //プレイヤーのステート


    //------------------------------------------

    //  初期化

    //------------------------------------------
    void Start () {
        Debug.Log("現在のキャラ数:" + Button_Act.char_num);

        player = PLAYER.NORMAL;
        //GameObject players = (GameObject)Resources.Load("Prefab/player");

        


        //------------------
        //  ノーマル
        if(Button_Act.char_select ==1)
        {
            Instantiate(players[0], new Vector3(0, 1.0f, 0), Quaternion.identity);
        }

        //------------------
        //  ノーマル
        if (Button_Act.char_select == 2)
        {
            Instantiate(players[1], new Vector3(0, 1.0f, 0), Quaternion.identity);
        }

        //------------------
        //  ノーマル
        if (Button_Act.char_select == 3)
        {
            Instantiate(players[0], new Vector3(0, 1.0f, 0), Quaternion.identity);
            Instantiate(players[1], new Vector3(0, 1.0f, 0), Quaternion.identity);
        }

        //------------------
        //  ノーマル
        if (Button_Act.char_select == 4)
        {
            Instantiate(players[3], new Vector3(0, 1.0f, 0), Quaternion.identity);
        }




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
