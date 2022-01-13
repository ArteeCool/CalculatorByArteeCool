using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;

public class EvaluateScript : MonoBehaviour
{
    public TextMeshProUGUI OutputNum;
    public char[] Chars = {'+', '-', '×', '÷'};
    public string[] ToSlove;
    public List<string> symbols = new List<string>();
    public List<string> FinalEquation = new List<string>();
    public double sum;
    
    public void Split()
    {
        if(!OutputNum.text.Contains("E"))
            if (OutputNum.text.EndsWith("×") || OutputNum.text.EndsWith("÷") || OutputNum.text.EndsWith("+") || OutputNum.text.EndsWith("-"))
            {
                
            }
            else
            {
                ToSlove = OutputNum.text.Split(Chars);



                for (int i = 0; i < OutputNum.text.Length; i++)
                {
                    switch (OutputNum.text[i])
                    {
                        case '+':
                        case '-':
                        case '×':
                        case '÷':
                            symbols.Add(Convert.ToString(OutputNum.text[i]));
                            break;
                    }
                }

                for (int i = 0; i < ToSlove.Length; i++)
                {
                    FinalEquation.Add(ToSlove[i]);

                    if (i < symbols.Count)
                        FinalEquation.Add(symbols[i]);
                }

                SOLUTION();

            }

    }

    public void SOLUTION()
    {
        for (int i = 0; i < FinalEquation.Count; i++)
            {
                if (FinalEquation[i] == "×")
                {
                    Debug.Log("In *");
                    Debug.Log(FinalEquation[i - 1] + FinalEquation[i] + FinalEquation[i + 1]);
                    sum = Convert.ToDouble(FinalEquation[i - 1]) * Convert.ToDouble(FinalEquation[i + 1]);
                    FinalEquation[i] = Convert.ToString(sum);
                    FinalEquation.RemoveAt(i - 1);
                    FinalEquation.RemoveAt(i);

                }
            }
            
            for (int i = 0; i < FinalEquation.Count; i++)
            {

                if (FinalEquation[i] == "÷")
                {
                    Debug.Log("In ÷");
                    Debug.Log(FinalEquation[i - 1] + FinalEquation[i] + FinalEquation[i + 1]);
                    sum = Convert.ToDouble(FinalEquation[i - 1]) / Convert.ToDouble(FinalEquation[i + 1]);
                    FinalEquation[i] = Convert.ToString(sum);
                    FinalEquation.RemoveAt(i - 1);
                    FinalEquation.RemoveAt(i);

                }
            }
            
            for (int i = 0; i < FinalEquation.Count; i++)
            {

                if (FinalEquation[i] == "+")
                {
                    Debug.Log("In +");
                    Debug.Log(FinalEquation[i - 1] + FinalEquation[i] + FinalEquation[i + 1]);
                    sum = Convert.ToDouble(FinalEquation[i - 1]) + Convert.ToDouble(FinalEquation[i + 1]);
                    FinalEquation[i] = Convert.ToString(sum);
                    FinalEquation.RemoveAt(i - 1);
                    FinalEquation.RemoveAt(i);

                }
            }
            
            for (int i = 0; i < FinalEquation.Count; i++)
            {

                if (FinalEquation[i] == "-")
                {
                    Debug.Log("In -");
                    Debug.Log(FinalEquation[i - 1] + FinalEquation[i] + FinalEquation[i + 1]);
                    sum = Convert.ToDouble(FinalEquation[i - 1]) - Convert.ToDouble(FinalEquation[i + 1]);
                    FinalEquation[i] = Convert.ToString(sum);
                    FinalEquation.RemoveAt(i - 1);
                    FinalEquation.RemoveAt(i);

                }
            }

            OutputNum.text = FinalEquation[0];
            FinalEquation.Clear();
            Array.Clear(ToSlove,0, ToSlove.Length);
            symbols.Clear();
        }
}



