using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{   
    public TMP_InputField Line_A, Line_B;
    public TMP_Text Result;
    


    
 public void Summ () {
    int a, b, c;
    a = int.Parse(Line_A.text);
    b = int.Parse(Line_B.text);
    c = a + b;

    Result.text = c.ToString();
 }

  public void Difference () {
    int a, b, c;
    a = int.Parse(Line_A.text);
    b = int.Parse(Line_B.text);
    c = a-b;

    Result.text = c.ToString();
  }

    public void Multiplication () {
    int a, b, c;
    a = int.Parse(Line_A.text);
    b = int.Parse(Line_B.text);
    c = a*b;

    Result.text = c.ToString();
  }

      public void Division () {
    double a, b, c;
    a = int.Parse(Line_A.text);
    b = int.Parse(Line_B.text);
    c = a/b;
    
    if (b == 0)
    {
    Result.text = "Делить на 0 нельзя";
    }
    else
    {
        Result.text = c.ToString();
    }
  }
}
