using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _15Static : MonoBehaviour
{
    /*
        1. 정적 클래스
            - class 앞에 static 키워드를 붙여 생성
            - ** 인스턴스화 할 수 없다! **
                -> 하나의 인스턴스처럼 취급
                -> 클래스 이름 자체로 정적 클래스 멤버에 접근한다!
                Q. 정적 클래스를 구현하고 Start 함수에서 정적 클래스의 메서드에 접근하기

        2. 정적 멤버
            - 정적 클래스가 아닌 클래스에도 정적 멤버를 구현할 수 있다.
            - 정적 멤버에서의 static의 의미는 **instance와 무관한 멤버**
                -> 모든 instance에 대해서 같은 값을 가지게 된다. 
                ex) EnemyCount
                ex2) Singleton pattern

            
        
     */

    void Start(){
        Monster m = new Monster(10);
        Monster m2 = new Monster(20);
        Monster m3 = new Monster(30);

        Debug.Log(Monster.monsterCount);
    }

}

public class Monster{
    public int HP;

    public static int monsterCount;

    public Monster(int HP){
        this.HP = HP;
        monsterCount++;
    }
}


