using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Text_Controller : MonoBehaviour
{
    public Text newText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Galen McGehee!";
        }
    
    
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
