using UnityEngine;

public class _8Class : MonoBehaviour
{
    /*
        0. 객체지향언어 ex. C#, JAVA
            - 절차지향언어 ex. C
            - 객체지향이 특별한 점 -> "객체"

        1. 클래스란?
            - 틀, 설계도 -> Type
                - user-defined data type
                - 클래스를 만든다 -> 타입을 정의한다!
            - 클래스와 객체 -> Animal과 lion 
            - 멤버 
                - 멤버 : 클래스의 구성요소
                - 필드와 메서드

        Q. Enemy class 생성하기

        2. 클래스의 이해
            - 필드와 메서드
                - 필드 : 속성, 특징
                - 메서드 : 행위
            
            Q. Hp와 TakeDamage 구현

        3. 객체(인스턴스)
            - 클래스에 기반을 둔 구체적 엔티티
                - 클래스라는 틀에 의해 구현된 실물
            - 객체를 만드는 방법 : new 키워드 (유니티에서는 게임오브젝트 생성)

        ** 참조하다 (메모리 참조 이해하기)
            // 변수 -> 값형 변수, 참조형 변수
        
        Q. 예제로 값형, 참조형 이해하기

        4. 생성자 (Constructor)
        - 객체가 생성될 때 실행되는 함수
        - 객체 초기화의 개념
            - this : 객체를 가리키는 키워드
        - parameter 받기

        Q. Enemy 초기화하기  
     */

    void Start()
    {
        testClass tt = new testClass(3);
        tt.PrintA();
    }

    class testClass
    {
        public int a;

        // public testClass(){

        // }

        public testClass(int _a)
        {
            a = _a;
        }

        public void PrintA()
        {
            Debug.Log(a);
        }
    }

}