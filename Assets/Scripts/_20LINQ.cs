using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class _20LINQ : MonoBehaviour
{
    /*
        1. LINQ
            - 데이터를 효율적으로 처리하는 기법
            - Language INtegrated Query -> 데이터 처리를 위해 언어에 쿼리를 통합
                -> 문법이 SQL 쿼리와 흡사함
                - 쿼리를 모르는 상태에서 굳이 알아야 하나...싶긴 합니다
            - Collection, foreach와 같이 자주 사용됨

            - 기본 용법
               
                - var 변수이름 = from 클래스명 in Collection변수명 where 조건 select 클래스이름 ;
        Q. Animal 이라는 클래스를 만들고 나이가 10 이상인 동물의 이름을 출력하라
     */

    List<Fish> fishes = new List<Fish>();

    void Start()
    {
        fishes.Add(new Fish(10, "boonger"));
        fishes.Add(new Fish(3, "shark"));
        fishes.Add(new Fish(1, "whale"));
        fishes.Add(new Fish(19, "goldenfish"));

        // Q. 나이가 10보다 어린 물고기 이름들 출력해줘
        foreach (var item in fishes)
        {
            if (item.age < 10)
            {
                Debug.Log(item.name);
            }
        }
    }

}

public class Fish{
    public int age;
    public string name;

    public Fish(int age, string name){
        this.age = age;
        this.name = name;
    }

}
