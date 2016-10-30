using UnityEngine;
using System.Collections;

//-----------------------------------------------------------------

//  ベースプレイヤーのクラス

//-----------------------------------------------------------------
public class BasePlayer : BaseCharacter
{

    protected enum P_State
    {
        CONTROL = 0,                 //操作する
        TRAKING,                     //プレイヤーを 追尾する
    }

    [SerializeField]
    protected GameObject buddy = null;        //仲間

    [SerializeField]
    protected Vector2 tracking;      //追尾(仲間を追尾)

    private float jump = 3.5f;

    [SerializeField]
    protected P_State p_state;         //プレイヤーのステート

    [SerializeField]
    protected bool stopflg;

    private static int change_p;       //プレイヤー切り替え

    [SerializeField]
    protected Animator animator;

    //------------------------------------------

    //  初期化

    //------------------------------------------
    public virtual void Start()
    {
    }


    //------------------------------------------

    //  更新

    //------------------------------------------
    public virtual void Update()
    {

    }



    //------------------------------------------

    //  移動

    //------------------------------------------
    public void Control()
    {
        float control = Input.GetAxis("Horizontal");



        if (control != 0)
        {
            rigidbody.velocity = new Vector2(control * spd, rigidbody.velocity.y);
        }
        else
        {
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            var anime = this.gameObject.GetComponent<Animator>();
            rigidbody.velocity = new Vector2(0, jump);
        }

    }



    //------------------------------------------

    //  移動追尾

    //------------------------------------------
    public void Traking()
    {
        tracking = buddy.transform.position - transform.position;

        rigidbody.velocity = new Vector2(tracking.x * (spd / 2), rigidbody.velocity.y);
    }






}
