using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _16Interface : MonoBehaviour
{
    /*
        1. 인터페이스
            - 상속관계가 없는 클래스에 기능을 제공하는 구조
            - 추상 메서드, 추상 속성을 멤버로 가질 수 있다.
            - 모든 멤버가 abstract인 추상 클래스와 비슷한 구조

            Q. interface 구현해보기

        2. 인터페이스의 활용
            - 클래스는 ** 여러개의 Interface를 장착할 수 있다. **
                -> 추상클래스와의 차이점
            - 클래스가 인터페이스를 장착하면 인터페이스에 구현된 멤버를 구현해야 한다.
     */
}

public class Human
{

}

public class Weapon2{
    public int a ;
    public void Gun(){

    }
}

public interface Weapon{
    void Attack();
}

public interface Armor{
    void Guard();
}