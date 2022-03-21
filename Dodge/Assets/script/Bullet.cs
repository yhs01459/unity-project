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
            PlayerControllor playerControllor = other.GetComponent<PlayerControllor>(); //�浹�� �ٸ� ���� ������Ʈ�� ������Ʈ ��������

            if (playerControllor != null)
            {
                playerControllor.Die();
            }
        }
    }
}
