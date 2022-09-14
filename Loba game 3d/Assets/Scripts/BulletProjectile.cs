using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private Transform vfxHit1;
    [SerializeField] private Transform vfxHit2;
    [SerializeField] private Transform gunVfx;

    private Rigidbody bulletRigidbody;

    public GameObject Enemy;

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 20f;
        bulletRigidbody.velocity = transform.forward * speed;
        Instantiate(gunVfx, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<BulletTarget>() != null)
        {
            // hit taget
            Instantiate(vfxHit1, transform.position, Quaternion.identity);
        } 
        else 
        {
            // hit something else
            Instantiate(vfxHit2 , transform.position, Quaternion.identity);
        }

        if(other.gameObject.tag.Equals("Enemy"))
        {
            Score.scoreValue += 10;
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
