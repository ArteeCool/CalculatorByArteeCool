using System;
using TMPro;
using UnityEngine;


public class InputScript : MonoBehaviour
{
    public TextMeshProUGUI OutputNum;
    public bool PointerDown;
    public float Value;
    public float currentTime;

    public void Input()
    {
        if (OutputNum.text.Length >= 48)
        {
            
        }
        else
        {
            if (Value == 0)
            {
                if (OutputNum.text == "0")
                {
                 
                }
                else
                {
                    OutputNum.text += Value;
                }
            }
            else
            {
                if (OutputNum.text == "0")
                {
                    OutputNum.text = Value.ToString();   //Convert.ToString(Value);
                }
                else
                {
                    OutputNum.text += Value;
                }
            
            }
        }
        
    }

    public void ClearOneSymbol()
    {
        if (OutputNum.text.Length <= 0 || OutputNum == null)    
            return;
        
        OutputNum.text = OutputNum.text.Remove(OutputNum.text.Length-1, 1);


    }
    
    public void ClearAllSymbols()
    {
        PointerDown = true;
        currentTime = Time.time + 0.35f;
    }
    
    public void False()
    {
        PointerDown = false;
    }



    private void Update()
    {
        if (PointerDown == true)
        {
            Debug.Log("currentTime " + currentTime );
            Debug.Log(Time.time);
            if (Time.time > currentTime)
            {
                Debug.Log("In second if");
                OutputNum.text = "";
                PointerDown = false;
            }

        }
    }
}
