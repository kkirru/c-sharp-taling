using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class _13Struct : MonoBehaviour
{
    /*
        1. 구조체란?
            - 구조체 또한 클래스 처럼 user-defined data type
            - 비교적 간단한 객체를 만들기 위해 사용됨
                - 메모리 활용에 효율적!
                -> 왜냐하면 구조체는 value-type이기 때문 => 참조를 위한 추가적인 메모리 할당이 필요 없음
                - 우리가 알고 있는 int, float, char, bool 등의 data type은 struct로 구현되어 있음 -> value-type

        2. 클래스와의 차이
            2.1 구조체는 상속 불가능
                - 인터페이스는 사용 가능

            2.2 value-type이기 때문에 값을 전달할 때 데이터를 복사한다.
                - 따라서, 앞서 클래스를 공부할 때의 객체 참조랑 차이점을 주의해야 함
                Q. 클래스와 구조체로 Point 구현
                    ** $" {} 패턴
     */

    public Sprite sprite;

    void Start(){
        int row = 10;
        int col = 10;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Point pp = new Point(i,j,sprite);
            }
        }
    }
}

public struct Point{
    public int x;
    public int y;
    public Sprite sprite;
    

    public Point(int x, int y, Sprite sprite){
        this.x = x;
        this.y = y;
        this.sprite = sprite;

        CreateDot();
    }

    public void Print(){
        Debug.Log($"({x},{y})");
    }

    public void CreateDot(){
        GameObject go = new GameObject();
        go.transform.position = new Vector2(x,y);
        go.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        go.AddComponent<SpriteRenderer>().sprite = this.sprite;
    }
    
}