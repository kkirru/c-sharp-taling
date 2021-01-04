using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _14Abstract : MonoBehaviour
{
    /*
        1. 추상클래스
            - 추상 클래스 : 불완전한 클래스
            - 부모 클래스에서 abstract 키워드를 이용하여 멤버를 구현하고 자식 클래스에서 이를 완성하도록 강제함
                - 자식 클래스에서 꼭 구현해야할 것들을 abstract로 구현
            - 추상 클래스는 인스턴스화 할 수 없음

        2. 추상 메서드
            - 추상 메서드는 abstract 키워드가 필요함며 메서드의 body 부분은 구현하지 않는다.
            Q. Parent 클래스에 추상 메서드 구현하고 자식 클래스에서 어떻게 구현해야 하는지 확인하기
                - override : 재정의
     */
}

abstract class Bird{
    protected abstract void Move();
    public abstract void Eat();
    public abstract void Die();
}

class Eagle : Bird
{
    public override void Die()
    {
        throw new System.NotImplementedException();
    }

    public override void Eat()
    {
        throw new System.NotImplementedException();
    }

    protected override void Move()
    {
        throw new System.NotImplementedException();
    }
}