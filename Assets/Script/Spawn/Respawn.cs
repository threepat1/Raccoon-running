using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject objects;
    float randomX;
    Vector2 whereToSpawn;
   
    float nextSpawn = 0.0f;
    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {

            nextSpawn = Time.time + 10 / (spawnDelay + CoinCollide.level);
            randomX = Random.Range(-7f,6f);
            whereToSpawn = new Vector2(randomX, transform.position.y);
            Instantiate(objects, whereToSpawn, Quaternion.identity);
        }
      
    }
   
}
