using UnityEngine;

public class BehaviourScript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float myRandom = Random.Range(0f, 15f);
        Debug.Log(myRandom);

        Mathf.Abs(myRandom);
    }
}
