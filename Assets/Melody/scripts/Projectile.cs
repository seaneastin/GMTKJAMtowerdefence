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

    // Start is called before the first frame update
    void Start()
    {
            projectile = gameObject.GetComponent<CharacterController>();
            _forward = gameObject.transform.forward.normalized;
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
                Collider[] colliders = Physics.OverlapSphere(transform.position, 20);
                projectile.enabled = false;
                if (colliders.Length > 0)
                {
                    foreach (Collider nearbyobject in colliders)
                    {
                        Rigidbody rb = nearbyobject.GetComponent<Rigidbody>();
                        if (rb != null)
                        {
                            rb.gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionforce, gameObject.transform.position, explosionRadius, 3, ForceMode.Impulse);
                        }
                    }
                }
            }
            if(!CanExplode)
            {
                
            }
            GameObject.Destroy(gameObject);
            Debug.Log("help");
        }
    }
}
