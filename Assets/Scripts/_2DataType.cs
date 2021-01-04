using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _2DataType : MonoBehaviour
{
    int a = 1;
    string b = "a";
    char c = 'a';

    object aa = 1;
    object bb = 0.1f;
    object cc = "asdf";

    // 0,1 -> 비트
    // 00000000 -> 바이트
    // 킬로바이트 = 바이트 * 1000

    /*
    1. 자료형이란 : 그릇의 모양

    2. 자료형의 종류
        - 정수형 : int (-1,0,1,2...), long(-1,0,1,2)
        - 실수형 : float (0.1,0.2...), double 
        - 문자형 : ** string ("hello"), char ('a')
        - 논리형 : bool (true, false) 
        - 기타 : object (상속의 개념)

        - 여러개의 자료형이 존재하는 이유?
            - 메모리의 활용 최적화
            - 오류를 잡기 어려워요

    3. 기본값
    - 정수형 -> 0
    - 실수형 -> 0.00
    - 문자형 -> string : null
    - 논리형 -> false

     */
}
