using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _18Generic : MonoBehaviour
{
    /*
        1. 제네릭
            - 클래스 멤버 중 타입이 결정되어 있지 않을 때 사용
            - 객체를 생성할 때 타입을 정의해줌
            Q. 제네릭 구현
     */

    void Start(){
        Number<int, float> num = new Number<int, float>();


        // Number<float> num_1 = new Number<float>();
        // num_1.value = 0.1f;

        // RigidBody2D rr = gameObject.GetComponent<Rigidbody2D>();
    }

}

public class Number<T, R>{
    public T value;
    public R value_2;
}