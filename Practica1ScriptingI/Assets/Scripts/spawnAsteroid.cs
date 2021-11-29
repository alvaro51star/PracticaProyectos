using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAsteroid : MonoBehaviour
{
    private Transform transformSpawner;
    public GameObject asteroid;
    public float timeTillNextAsteroid = 2f;
    public float timeAsteroid = 2f;
    // Start is called before the first frame update
    void Start()
    {
        transformSpawner = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timeTillNextAsteroid -= Time.deltaTime;
        if(timeTillNextAsteroid <= 0)
        {
            GameObject asteroidSpawner = Instantiate(asteroid, new Vector3(Random.Range(2.55f, -2.55f),transformSpawner.position.y , 0), Quaternion.identity);
            timeTillNextAsteroid = timeAsteroid;
            Destroy(asteroidSpawner, 3);
        }
    }
}
