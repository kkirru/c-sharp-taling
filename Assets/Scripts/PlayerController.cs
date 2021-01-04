using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject player;
    public float speed; // 1f
    public GameObject gun;

    public GameObject bulletPrefab;
    public float bulletSpeed;
    public int numOfBullet;

    // 매 프레임마다 키가 눌렸는지 판단해서 그 방향에 맞게 이동 시켜준다.
    // Time.deltaTime -> 이전 프레임과의 시간 차이

    // GetKey -> 누르고 있는 동안
    // GetKeyDown -> 눌렷을 때 최초 1회
    // GetKeyUp -> 떼졌을 때 최초 1회
    void Start(){

    }

    void Update() // 10프레임
    {
        Vector2 inputVector = new Vector2(0,1);

        // Input
        // if (Input.GetKey(KeyCode.W))
        // {
        //     // player.transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
        //     player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,speed));
        //     inputVector.y = 1;
        // }

        // if (Input.GetKey(KeyCode.S))
        // {
        //     // player.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        //     player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-speed));
        //     inputVector.y = -1;
        // }

        if (Input.GetKey(KeyCode.A))
        {
            // player.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed,0));
            // player.GetComponent<Rigidbody2D>().velocity = new Vector2(-1 * speed,player.GetComponent<Rigidbody2D>().velocity.y);
            inputVector.x = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            // player.transform.Translate(new Vector3(speed * Time.deltaTime,0, 0));
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed,0));
            inputVector.x = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inputVector.magnitude != 0)
            {
                for (int i = 0; i < numOfBullet; i++)
                {
                    // 발사 해보자!
                    // 1. 총알을 생성
                    GameObject bullet = Instantiate(bulletPrefab);
                    // 초기 위치
                    bullet.transform.position = new Vector3(gun.transform.position.x, gun.transform.position.y, 0);
                    Vector2 playerVec = Vector2.zero;
                    playerVec = player.GetComponent<Rigidbody2D>().velocity.normalized;
                    // 2. 발사 -> AddForce(힘) -> 물리(Rigidbody)
                    // bullet.GetComponent<Rigidbody2D>().AddForce(playerVec * bulletSpeed * (1 + 0.1f *(i+1)));
                    // bullet.GetComponent<Rigidbody2D>().AddForce(inputVector * bulletSpeed * (1 + 0.1f *(i+1)));
                    bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed * (1 + 0.1f *(i+1)));
                }

            }
        }
        // if (Input.GetKeyDown(KeyCode.K)){
        //     player.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000,1000));
        // }
    }
}
