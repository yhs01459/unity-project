using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerControllor playerControllor = other.GetComponent<PlayerControllor>(); //충돌한 다른 게임 오브젝트의 컴포넌트 가져오기

            if (playerControllor != null)
            {
                playerControllor.Die();
            }
        }
    }
}
