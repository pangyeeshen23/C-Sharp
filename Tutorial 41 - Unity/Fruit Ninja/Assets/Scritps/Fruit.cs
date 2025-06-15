using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject slicedFruitPrefab;

    public void CreateSlicedFruit()
    {
        GameObject inst = (GameObject) Instantiate(slicedFruitPrefab, transform.position, transform.rotation);
        Rigidbody[] rbsOnSliced = inst.transform.GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rb in rbsOnSliced)
        {
            rb.transform.rotation = Random.rotation;
            int explosiveForce = Random.Range(100, 1000);
            rb.AddExplosionForce(explosiveForce, transform.position, 5f);
        }
        Destroy(inst.gameObject, 5f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Blade blade = collision.GetComponent<Blade>();
        if (!blade) return;
        CreateSlicedFruit();
    }
}
