using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _7ControlStatement : MonoBehaviour
{
    /*
    // Control statement -> 제어문
    1. 조건문
        - 어떤 조건에 맞을때만 실행하게 하는

    1.1 if
        if(condition) {
            실행될 코드
        }
        - else 키워드
        - if, else if, else if, .... , else

        Q. 키보드로 플레이어 조작해보기 (Player Controller 생성)

        Q. 발사체 생성
        ** Prefab 
            -> 복제할 수 있도록 만들어주는 설계도

    1.2 switch
        - 

    2. 반복문 
    1.1 for
        Q. 1부터 30까지 콘솔창에 출력해보자!

        Q. 여러개의 발사체 발사해보기

    1.2 while 

        Q. while이 필요한 이유
            ex) space가 입력될 때 까지 반복하라.

        ** break와 contiue 
     */

    public int num;
    public int a = 1;


    // 짝수 출력
    // 1. i*2 출력 (16까지만)
    // 2. i++ -> i += 2 
    // 3. if 와 % 연산자 활용 
    void Start()
    {
        for (int i = 1; i < 31; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
    void Update()
    {

    }


    void Button(string value){
        switch (value)
        {
            case "cancle":
            break;
            case "confirm":
            break;


            default:
            break;
        }
    }


    void OnClickCancel(){

    }

    void OnClickConfirm(){

    }
}
