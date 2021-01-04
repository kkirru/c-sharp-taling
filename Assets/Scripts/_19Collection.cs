using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _19Collection : MonoBehaviour
{
    /*
        1. 컬렉션
            - 크기가 고정된 배열의 단점을 보완하기 위해 구현된 클래스들을 모아놓은 네임스페이스
        2. List
            - 기본적으로 배열과 매우 유사하지만 크기가 유동적
            - 선언 : 제네릭 사용
                - List<T> list = new List<T>();
            - 사용법
                1. List 생성
                2. Add 메서드를 통해 요소 추가
                3. 배열과 마찬가지로 [] 를 통해 요소에 접근
                4. Remove 혹은 RemoveAt
                5. 그 밖의 다양한 메서드

        3. Dictionary
            - 요소에 인덱스를 매기는 것이 아니라 key를 정의하여 key-value 쌍을 만들어 저장
            - 선언 : 제네릭
                - Dictionary<string, int> dict = new Dictionary<string,int>();
            - 사용법
                1. Dcitnoary 생성
                2. Add 메서드를 통해 key-value pair 추가
                3. []를 통해 접근하지만 index가 아닌 key 사용
                4. Remove -> key 사용
                5. 그 밖의 다양한 메서드

     */

    Dictionary<int,Fish> dict = new Dictionary<int, Fish>();
    
    void Start(){
        // dict.Add(101, new Fish(10, "boonger"));
        // dict.Add(2003, new Fish(3, "shark"));
        // dict.Add(13, new Fish(1, "whale"));

        // Debug.Log(dict[13].name);


        // foreach (var KeyValuePair in dict)
        // {
        //     if (KeyValuePair.Value.name == "whale")
        //     {
        //         Debug.Log(KeyValuePair.Key);
        //     }
        // }

        // HelloWorld f = new Fish(10, "dafkj");
    }
}

// public class Fish{
//     public int age;
//     public string name;

//     public Fish(int age, string name){
//         this.age = age;
//         this.name = name;
//     }

// }
