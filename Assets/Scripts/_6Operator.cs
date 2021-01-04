using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _6Operator : MonoBehaviour
{
    int a = 1;

    public GameObject player;

    /*
        1. 연산자(operator) -> 연산 해주는 기호
            - 피연산자(operand)
            - ex) 1 + 1 => operator : + , operand : 1, 1

        2. 연산자의 종류
            1. 산술 연산자 -> 사칙연산 + %(나머지 연산자)  ex) 9%2 = 1
            2. 대입 연산자 -> =
                - 산술연산자와 결합이 가능
                - +=, -= , *=, /= 
                - ex) b = b + a 는 b += a 와 같다.
            3. 논리 연산자
                - bool을 계산하는 연산자    
                - &&, ||, &(AND), |(OR)
                - 두개 -> 판정 생략할 수 있음. 한개 -> 판정 생략 불가능
            4. 비교 연산자
                - 부등호
                - <, >, <=, >=
                - ==, !=
     */


    // ** SetActive
    //      - GameObject 를 끄고 켜는 역할을 함

    // scope
    // 지역변수와 전역변수
    // 지역변수 -> 접근제한자 X
    void Start(){
        int money = 11;
        player.SetActive(money > 10);
    }
    
    // Q. SetActive 이용하여 PlayerObject 끄고 켜기


}
