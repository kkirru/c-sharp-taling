using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _5Array : MonoBehaviour
{
    /*
    1. 배열이란
       - 같은 타입(자료형)의 변수를 처리하기 위한 데이터구조

    2. 배열의 선언과 초기화
        1. int[] a = new int[5]; (선언)
        2. int[] a = new int[]{1,2,3,4,5}; (초기화)
        3. int[] a = {1,2,3,4,5}; (초기화 줄임 표현)

    3. 배열의 사용
        - 배열 요소에 접근 (인덱스)
        - 배열 요소에 값 담기    
    */

    int a = 1;
    int b = 2;
    int c = 3;
    // int[] numbers2 = new int[3];
    int[] numbers = new int[]{1,2,3};

    void Start(){
        numbers[0] = 100;
        Debug.Log(numbers[0]);
        Debug.Log(numbers[1]);
        Debug.Log(numbers[2]);
    }




}
