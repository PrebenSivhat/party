using System;
using UnityEngine;
using System.Collections;
using System.Linq.Expressions;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour

    {
    public float SpawnMinX;
    public float SpawnMaxX;
    public float SpawnMinY;
    public float SpawnMaxY;
    public int PrefabRandomizer;


    public float SpawnRate;
    public float StartEnemies;
    public GameObject[] Enemies;

    private float MaximumEnemies;
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

	    MaximumEnemies = Time.fixedTime * 2 + StartEnemies;
        Debug.Log("Maximum Enemies should be: " + MaximumEnemies + 
                    ". Actual enemies: " + gameObject.transform.childCount);


        while (transform.childCount < MaximumEnemies)
        //&& SpawnTimer <= 0
        {
            
            

            SpawnEnemy();
	       //SpawnTimer = SpawnRate;
	    }
    }

    void SpawnEnemy()
    {
        var EnemySpawnRandomizer = Random.Range(0, 4);
        PrefabRandomizer = Random.Range(0, Enemies.Length);
        {
            var instance = Instantiate(Enemies[PrefabRandomizer], new Vector2(_coordinates[EnemySpawnRandomizer,0], _coordinates[EnemySpawnRandomizer,1]), Quaternion.identity) as GameObject;
            instance.transform.SetParent(transform);
            instance.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 2f), Random.Range(0f, 2f), Random.Range(0f, 2f), 1f);
        }



        //var randomSize = (Random.Range(0.1f, 2.5f));
        //instance.transform.localScale += new Vector3(randomSize, randomSize, 0);
        //instance.transform.parent = this.transform;
    }

}
