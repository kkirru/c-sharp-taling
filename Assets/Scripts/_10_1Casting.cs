using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_1Casting : MonoBehaviour
{
    void Start()
    {
        // 지난번 코드
        //    Enemy enemy;
        //    Enemy1 enemy1 = new Enemy1(); 
        
        //    Debug.Log(enemy1);

        //    if (enemy == null)
        //    {
        //        Debug.Log("실패");
        //    }

        // Enemy1 객체는 Enemy 변수로 형변환 되어야 하지만 null
        // 이유는 Enemy가 MonoBehaviour을 상속받기 때문
        // MonoBehaviour를 상속받은 클래스는 유니티에서만 객체를 생성할 수 있다.
        // 하지만 지금은 new 키워드를 통해 객체 생성했기 때문에 null

        // 바른 예
        Parent parent;
        Child child = new Child();

        parent = child as Parent;

        if (parent != null)
        {
            Debug.Log("성공");
        }
        else
        {
            Debug.Log("실패");
        }

        //

        Child child1;
        // Parent parent1 = new Parent();
        // child1 = parent1 as Child;
        // child1 = (Child)parent1;

        // if (child1 != null)
        // {
        //     Debug.Log("성공");
        // }
        // else
        // {
        //     Debug.Log("실패");
        // }
    }


}
