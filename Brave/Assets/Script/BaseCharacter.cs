using UnityEngine;
using System.Collections;


//-----------------------------------------------------------------

//  ベースキャラクターのクラス

//-----------------------------------------------------------------
public class BaseCharacter : MonoBehaviour
{

    [SerializeField]
    protected float spd;      //移動速度

    protected Vector2 move;     //位置

    [SerializeField]
    protected Rigidbody2D rigidbody = null;     //Rigidbody2D


    void Start()
    {
    }


    void Update()
    {

    }


}
