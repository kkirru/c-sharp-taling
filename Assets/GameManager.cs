using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Singleton 패턴
    public static GameManager instance;

    void Awake(){
        if(instance == null) {
            instance = this;
        } else{
            Destroy(this.gameObject);
        }
    }
    
    public Text scoreText;

    public int score;

    void Start(){
        LoadFile();

        UpdateScore();
    }

    public void UpdateScore(){
        scoreText.text = "Score : " + score.ToString();
    }

    public void SaveFile()
    {
        if (File.Exists("/Users/kkirru/Desktop/data.txt"))
        {
            File.Delete("/Users/kkirru/Desktop/data.txt");
        }

        File.WriteAllText("/Users/kkirru/Desktop/data.txt", score.ToString());
    }

    void LoadFile()
    {
        if (File.Exists("/Users/kkirru/Desktop/data.txt"))
        {
            string text = File.ReadAllText("/Users/kkirru/Desktop/data.txt");
            score = int.Parse(text);
        }

    }


}
