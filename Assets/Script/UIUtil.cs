using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUtil : MonoBehaviour
{
    private Button[] gameButton;
    private Text gameText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        gameButton = GameObject.FindObjectsOfType<Button>();
        int i = 0;
        for (i = 0; i < gameButton.Length; i++)
        {
            Debug.Log(gameButton[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
