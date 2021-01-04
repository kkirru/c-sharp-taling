using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    public string name;
    public int MP;

    void Start(){
        Hp = 100;
    }

    public override void Move(){
        transform.Translate(Vector2.left * 0.1f);
        Invoke("Move", 0.1f);
    }
}
