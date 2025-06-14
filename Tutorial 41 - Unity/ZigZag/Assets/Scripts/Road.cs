using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject roadPrefab;
    public Vector3 lastPost;
    public float offset = 0.707f;

    public void StartBuilding()
    {
        InvokeRepeating("CreateNewRoardPart", 1f, 0.5f);
    }

    public void CreateNewRoardPart()
    {
        Vector3 spawnPost = Vector3.zero;
        float chance = Random.Range(0f, 100);
        float crystalGen = Random.Range(0f, 100);
        if (chance < 50)
        {
             spawnPost = new Vector3(lastPost.x + offset, lastPost.y, lastPost.z + offset);
        }
        else
        {
            spawnPost = new Vector3(lastPost.x - offset, lastPost.y, lastPost.z + offset);
        }
        GameObject g = Instantiate(roadPrefab, spawnPost, Quaternion.Euler(0, 45, 0));
        if (crystalGen > 50) g.transform.GetChild(0).gameObject.SetActive(true);
        lastPost = g.transform.position;
    }
}
