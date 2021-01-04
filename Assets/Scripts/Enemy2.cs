using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    public float mp = 1;


    public void SetMp(float mp){
        
    }

    public void RecoverHealth(){
        Hp = 100;
    }

    public override void Move(){
        transform.Translate(Vector2.right * 0.1f);
        Invoke("Move", 0.1f);
    }
}
