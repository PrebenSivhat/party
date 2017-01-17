using UnityEngine;
using System.Collections;

public class EnemyController : Movement
{
  
    private float ConstantSpeed;
    private float ConstantRotationSpeed;
    public Rigidbody2D _rbody;

    public ParticleSystem ExplosionParticle;

    private void Start()
    {
       ConstantRotationSpeed = Random.Range(EnemyMinRotationSpeed, EnemyMaxRotationSpeed);
       ConstantSpeed = Random.Range(EnemyMinSpeed, EnemyMaxSpeed);
       _rbody = GetComponent<Rigidbody2D>();
        Move(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

    private void Update()
    {
        // Keep moving object with constant speed
        _rbody.velocity = ConstantSpeed * (_rbody.velocity.normalized);
        Rotate(1f, -1f, ConstantRotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case ("Player1"):
            case ("Player2"):
            case ("Player3"):
            case ("Player4"):
                Instantiate(ExplosionParticle, transform.position, Quaternion.identity);
                Destroy(gameObject);
                break;
            case ("Shredder"):
                Destroy(gameObject);
                break;
        }

    }
}
