using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public GameObject EnemyPrefab1;
    public GameObject EnemyPrefab2;


    // Start is called before the first frame update
    void Start()
    {
        // GameObject enemy1 = Instantiate(EnemyPrefab1);
        // enemy1.transform.position = new Vector3(5,3,-1);
        // Move(enemy1.GetComponent<Enemy1>());

        // GameObject enemy2 = Instantiate(EnemyPrefab2);
        // enemy2.transform.position = new Vector3(-5,3,-1);
        // Move(enemy2.GetComponent<Enemy2>());
        GameObject enemy = Instantiate(EnemyPrefab);
        enemy.transform.position = new Vector3(-5,3,-1);
        Move(enemy.GetComponent<Enemy>());
    }

    void Move(Enemy enemy){
        enemy.Move();
    }


    // void Spawn(){
    //     GameObject enemy = Instantiate(EnemyPrefab);
    //     Enemy ee = enemy.GetComponent<Enemy>();
    //     ee.Move();
    // }
    void Spawn1(){
        GameObject enemy = Instantiate(EnemyPrefab1);
        Enemy ee = enemy.GetComponent<Enemy1>();
        ee.Move();
    }
    //     void Spawn2(){
    //     GameObject enemy = Instantiate(EnemyPrefab2);
    //     Enemy2 ee = enemy.GetComponent<Enemy2>();
    //     ee.Move();
    // }
}
