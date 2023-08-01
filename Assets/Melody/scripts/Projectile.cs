using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    CharacterController projectile;
    private Vector3 _forward;
    public bool CanExplode;
    public int explosionRadius;
    public int explosionforce;
    public int speed;
    public int Damage;

    // Start is called before the first frame update
    void Start()
    {
            projectile = gameObject.GetComponent<CharacterController>();
            _forward = gameObject.transform.forward.normalized;
        _forward *= speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (projectile.enabled)
        {
            projectile.Move(_forward * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground") || (other.CompareTag("Goblin")))
        {
            if (CanExplode)
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
                projectile.enabled = false;
                if (colliders.Length > 0)
                {
                    foreach (Collider nearbyobject in colliders)
                    {
                        Rigidbody rb = nearbyobject.GetComponent<Rigidbody>();
                        if (rb != null)
                        {
                            if (rb.gameObject.GetComponent<GloblinAi>() != null)
                            {
                                Debug.Log("sja[v");
                                rb.gameObject.GetComponent<GloblinAi>().TakeDamage(1);
                            }
                            rb.gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionforce, gameObject.transform.position, explosionRadius, 3, ForceMode.Impulse);
                        }
                    }
                }
            }
            if(!CanExplode)
            {
                if(other.CompareTag("Goblin") || other.CompareTag("Player"))
                {
                    other.GetComponent<GloblinAi>().TakeDamage(Damage);
                }
            }
            GameObject.Destroy(gameObject);
            Debug.Log("help");
        }
    }
}
