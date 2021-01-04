using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameManager GM;

    // property 자동완성의 2가지 경우
    // 첫 번째는 참조 모두 바꿈. 두 번째는 그대로 유지
    [SerializeField] protected float hp = 100;
    public float Hp
    {

        get => hp;
        set
        {
            hp = value;
            Debug.Log("어! 누가 변경했어!");
        }
    }
    

    protected void Start(){

        // 유니티 하이어라키에서 "GameManager" 라는 이름을 가진 Object를 찾아오기
        GameObject Obj = GameObject.Find("GameManager");
        // 오브젝트에 부착되어 있는 GameManager Component 가져오기
        Debug.Log(Obj);
        
        GM = Obj.GetComponent<GameManager>();
        

    }

    void Die(){
        GameManager.instance.score ++;
        GM.UpdateScore();
        GM.SaveFile();
        
        Destroy(this.gameObject);
    }

    public void TakeDamage(float damage){

         if (Hp <= 0)
        {
            Die();
        } else{
            hp -= damage;
        }
    }

    public void TakeDamage(int ratio){
        Hp *= (1-ratio);
    }

    public void Attack(){
        Debug.Log("Attack!");
    }

    public virtual void Move(){
        transform.Translate(Vector2.left * 0.1f);
        Invoke("Move", 0.1f);    }
}
