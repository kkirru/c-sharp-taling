using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletDamage;
    public GameObject effect; 

    // 코루틴
    void Start()
    {
        // 3초 후에 없어져라
        Invoke("Die", 3f);

    }

    void Die(){
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other){
        // 만약에 닿은 친구가 Enemy인지 판정
        if (other.CompareTag("Enemy"))
        {
            // 몬스터에게 데미지 입혀라!
            // Enemy 스크립트로 가서 TkeDamage 함수 실행
            Enemy e = other.GetComponent<Enemy>();
            e.TakeDamage(bulletDamage);

            Die();
        }
    }


}
