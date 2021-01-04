using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10Inheritance : MonoBehaviour
{
    /*
        1. 상속이란
            - 객체지향의 4가지 특성 중 3번째 특성
            - 부모와 자식, 베이스 클래스와 파생 클래스(derived class)
            - 부모 클래스의 멤버를 그대로 이어 받는다.  --> 코드 재사용 --> 중복 제거
            - 다중 상속은 불가능 (부모와 자식 관계 생각)

        Q. Enemy1, Enemy2 클래스를 생성하고 Enemy 클래스를 상속받는다.

        2. 상속에서의 접근 제한자
            - protected 

        Q. Enemy2에 RecoverHealth Method 구현
        
        3. this와 base
            - this -> 객체 자신을 가리킴
            - this() -> 생성자 가리킴 
            - base -> 부모 클래스의 멤버에 접근할 때 사용

        4. 형변환
            1. 암시적 형변환 (특수 -> 일반)
                - up-casting
                - Enemy1 객체 -> Enemy 변수
                -> Base class reference can point to the Derived Class instance
            2. 명시적 형변환 (일반 -> 특수)
                - down-casting
                - Enemy객체 -> Enemy1 변수
                    - Error!
                    - Enemy1 의 멤버는 Enemy 에는 정의 X
                -> Derived class reference can not point to the Base Class instance
            3. as 키워드
                - 형변환이 가능하다면 형변환
                - 형변환이 불가능하다면 null

            4. is 키워드
                - 확인만
                - 값형 변수에도 사용
     */

    void Start()
    {
        // 지난번 코드

        // 오류의 이유


        // 2. as의 활용
        Parent parent;
        Child child = new Child();
        parent = child;

        // Enemy enemy = new Enemy();
        // Enemy1 enemy1 = enemy as Enemy1;

        if (parent != null)
        {
            Debug.Log("success");
        }
        else if(child == null)
        {
            parent.Show();
            Debug.Log("failed");
            
        }

        // if (enemy1 is Enemy)
        // {
        //     Debug.Log("형변환 성공");
        // }
        // else
        // {
        //     Debug.Log("형변환 실패");
        // }


    }






}
