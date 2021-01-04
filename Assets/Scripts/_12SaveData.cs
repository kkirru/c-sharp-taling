using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class _12SaveData : MonoBehaviour
{
    /*
    1. PlayerPrefs
        - 유니티에서 데이터를 저장하는 가장 간단한 방식 (유니티 엔진 제공)
        - int, float, string 값을 저장하는 데 사용된다
        - 게임을 종료해도 저장값이 유지된다. 

        1.1. Set Method
            - SetFloat
            - SetInt
            - SetString
    
        1.2. Get Method
            - SetFloat
            - SetInt
            - SetString

        1.3. Delete Method
            - DeleteKey
            - DeleteAll

    2. File
            - System.IO namespace 사용
            - 파일의 형태로 기기에 저장됨
            - PlayerPrefs 보다 훨씬 더 자유로운 형식으로 저장 ex) json
     */

     void Start(){
         FileSave();
         FileLoad();
     }

    void FileSave()
    {
        if (File.Exists("/Users/kkirru/Desktop/data.txt"))
        {
            File.Delete("/Users/kkirru/Desktop/data.txt");
        }

        File.WriteAllText("/Users/kkirru/Desktop/data.txt", "saved data");
    }

    void FileLoad(){
        if (File.Exists("/Users/kkirru/Desktop/data.txt"))
        {
            string text = File.ReadAllText("/Users/kkirru/Desktop/data.txt");
            Debug.Log(text);
        }

    }
}

