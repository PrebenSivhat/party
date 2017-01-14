using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public float MaxSpeed;
    public float MinSpeed;
    public ParticleSystem ExplosionParticle;
    

    private Rigidbody2D rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Movement.Move(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 1);
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case ("Player1"):
            case ("Player2"):
                Instantiate(ExplosionParticle, transform.position, Quaternion.identity);
                Destroy(gameObject);
                break;
            case ("Shredder"):
                Destroy(gameObject);
                break;
        }

    }
}
