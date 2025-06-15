using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruitToSpawn;
    public float minWait = .3f;
    public float maxWait = 1f;
    public float minForce = 12;
    public float maxForce = 17;
    public Transform[] spawnPlaces;

    public void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));
            Transform t = spawnPlaces[Random.Range(0, spawnPlaces.Length)];
            GameObject fruit = Instantiate(fruitToSpawn, t.position, t.rotation);
            fruit.GetComponent<Rigidbody2D>().AddForce(t.transform.up * Random.Range(minForce, maxForce), ForceMode2D.Impulse);
            Destroy(fruit, 5);
        }
    } 

}
