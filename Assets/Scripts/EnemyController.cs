using UnityEngine;
using System.Collections;

public class EnemyController : Movement
{
    public float MaxSpeed;
    public float MinSpeed;
    public float MaxRotationSpeed;
    public float MinRotationSpeed;

    public ParticleSystem ExplosionParticle;

    private void Start()
    {
      Move(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(MinSpeed, MaxSpeed));
      }

    private void Update()
    {
     Rotate(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(MinRotationSpeed, MaxRotationSpeed));
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
