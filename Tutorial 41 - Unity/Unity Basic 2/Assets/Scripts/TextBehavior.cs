using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class TextBehavior : MonoBehaviour
{
    public TextMeshProUGUI myText;
    int textNumber = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            textNumber++;
            myText.text = textNumber.ToString();
        }else if(Input.GetKeyDown(KeyCode.S))
        {
            myText.text = "S was pressed";
        }
    }
}
