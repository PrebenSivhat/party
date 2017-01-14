using System;
using UnityEngine;
using System.Collections;
using System.Linq.Expressions;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour

    {
    public float SpawnMinX;
    public float SpawnMaxX;
    public float SpawnMinY;
    public float SpawnMaxY;

    public float SpawnRate;
    public float MaximumEnemies;
    public GameObject[] Enemies;
    private float SpawnTimer = 1f;
    private float[,] _coordinates;
    
	void Start () {
        
    }
	
	void Update ()
	{
        SpawnTimer -= Time.deltaTime;
	    _coordinates = new float[4, 2]
	    {
	        {SpawnMinX,                             Random.Range(SpawnMinY, SpawnMaxY)},
	        {Random.Range(SpawnMinX, SpawnMaxX),    SpawnMinY},
            {Random.Range(SpawnMinX, SpawnMaxX),    SpawnMaxY},
            {SpawnMaxX,                             Random.Range(SpawnMinY, SpawnMaxY)}
	        
	    };
        
        while (transform.childCount < MaximumEnemies && SpawnTimer <= 0)
	    {
            SpawnEnemy(0);
	        SpawnTimer = SpawnRate;
	    }
    }

    void SpawnEnemy(int enemyIndex)
    {
        var arrayRandomizer = Random.Range(0, 4);
       
        var instance = Instantiate(Enemies[enemyIndex], new Vector2(_coordinates[arrayRandomizer,0], _coordinates[arrayRandomizer,1]), Quaternion.identity) as GameObject;

        var randomSize = (Random.Range(0.1f, 2.5f));
        instance.transform.localScale += new Vector3(randomSize, randomSize, 0);
        instance.transform.parent = this.transform;
   }

}
