using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _3Variable : MonoBehaviour
{
    // data type (built in data type)
    int a;
    string b;

    // 클래스(user defined data type) -> 자료형의 부분집합 
    public GameObject player;

    /*
    1. 변수란 : 값을 담는 그릇
        - value type (값 형식)
        - reference type (참조 형식)

    2. 변수 선언 및 초기화
        - 선언 : [자료형] [변수명];
        - 초기화 : [자료형] [변수명] = [값]; (선언하면서 값을 넣어주는 것)
    
    Q. 변수 초기화 후 유니티 콘솔에 값 출력해보기

    3. GameObject
        - 유니티에서 제공하는 자료형
        - 자료형과 클래스?
    
    Q. GameObject 변수 생성 후 스크립트에서 Transform의 position 조정해보기    
     */

    // . -> '의'
     void Start(){
        //position
        player.transform.position = new Vector3(1,1,1);
     }
}
