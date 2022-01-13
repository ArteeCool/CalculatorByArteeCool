using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharrInputScript : MonoBehaviour
{
    public TextMeshProUGUI OutputNum;
    public string Symbol;
    public void Input()
    {
        if (OutputNum.text == String.Empty)
        {
        }
        else if(OutputNum.text == "0")
        {
        }
        else if (OutputNum.text.EndsWith("+") && Symbol != "+")
        {
            OutputNum.text = OutputNum.text.Remove(OutputNum.text.Length - 1, 1);
            OutputNum.text += Symbol;
        }
        else if (OutputNum.text.EndsWith("-") && Symbol != "-")
        {
            OutputNum.text = OutputNum.text.Remove(OutputNum.text.Length-1, 1);
            OutputNum.text += Symbol;
        }
        else if (OutputNum.text.EndsWith("×") && Symbol != "×")
        {
            OutputNum.text = OutputNum.text.Remove(OutputNum.text.Length-1, 1);
            OutputNum.text += Symbol;
        }
        else if (OutputNum.text.EndsWith("÷") && Symbol != "÷")
        {
            OutputNum.text = OutputNum.text.Remove(OutputNum.text.Length-1, 1);
            OutputNum.text += Symbol;
        }
        else if(!OutputNum.text.EndsWith(Symbol))
        {
            OutputNum.text += Symbol;
        }
    }
}
