using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ticked : MonoBehaviour
{
    public Text boxText;
    public Button thisBox;
    // Update is called once per frame
    void Start()
    {
        Button btn = thisBox.GetComponent<Button>();
        thisBox.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick()
    {
        if (Gameplay.count > 0 && boxText.text == "")
        {
            if (Gameplay.count % 2 == 0)
                boxText.text = "O";
            else
                boxText.text = "X";
        }
        else Gameplay.count--;
    }
    
}
