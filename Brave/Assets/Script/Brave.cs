using UnityEngine;
using System.Collections;


//-----------------------------------------------------------------

//  勇者クラス

//-----------------------------------------------------------------
public class Brave : BasePlayer
{


    [SerializeField]
    private string tag_name;        //タグ名

    [SerializeField]
    private Camera camera;          //カメラ

    //------------------------------------------

    //  初期化

    //------------------------------------------
    public override void Start()
    {
    }



    //------------------------------------------

    //  更新

    //------------------------------------------
    public override void Update()
    {


        switch (p_state)
        {
            case P_State.CONTROL:      //操作
                Control();
                break;

            case P_State.TRAKING:      //追尾
                if (!stopflg)
                {
                    Traking();
                }
                break;
        }
        Replacement();
        Camera_Target();
    }


    //------------------------------------------

    //  カメラのターゲット

    //------------------------------------------
    void Camera_Target()
    {
        if (p_state == P_State.CONTROL)
        {
            camera.transform.position = new Vector3(transform.position.x, 0.27f, -5);
        }

    }

    //------------------------------------------

    //  操作キャラの入れ替え

    //------------------------------------------
    void Replacement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            p_state++;
        }



        if (p_state > P_State.TRAKING)
        {
            p_state = P_State.CONTROL;
        }
    }

    //------------------------------------------

    //  範囲内に入れば動かない

    //------------------------------------------
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == tag_name)
        {
            stopflg = true;
        }
    }


    //------------------------------------------

    //  範囲外に行けば動く

    //------------------------------------------
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == tag_name)
        {
            stopflg = false;
        }
    }



}
