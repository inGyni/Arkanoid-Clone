using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text text;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name.Contains("block")) 
        {
            text.text = (int.Parse(text.text) + 1).ToString();
        }
        if (text.text == "40")
        {
            text.text = "You've won!, Good Job!";
        }
    }
}
