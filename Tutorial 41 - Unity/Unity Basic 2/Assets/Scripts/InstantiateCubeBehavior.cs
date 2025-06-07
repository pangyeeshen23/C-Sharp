using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform prefab;
    int counter = 0;


    private void Start()
    {
        //InvokeRepeating("CreateNewCube", 3f, 1f);
        Invoke("CreateNewCube", 5f);
    }

    public void CreateNewCube()
    {
        Instantiate(prefab, new Vector3(-10 + counter * 3.0f, 0, 0), Quaternion.identity);
        counter++;
        if (counter >= 5) CancelInvoke();
    }
}
