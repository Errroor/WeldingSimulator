using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ecran : MonoBehaviour
{
    public TextMesh display;
    public rezistor rez;
    public battery batt;
    public lamp Lamp;
    public buttonscheme bs;
    public float silatoka;
    public int steps;
    public int rejims;
    public Text ecraN;
    public bool klems = false;
    private void Start()
    {
        
    }
    private void Update()
    {
        silatoka = (batt.napryajeniye / (rez.soprotivleniye+ Lamp.soprotivleniye)) ;
        if (steps == 4)
        {
            steps = 1;
        }
        else if (steps == 0)
        {
            steps = 3;
        }
        InputMenu(rejims);
    }

    public void InputMenu(int value)
    {
        if (bs.step == true && klems)
        {
            if (value == 0)
            {
                if (steps == 1)
                {
                    display.text = (silatoka * Lamp.soprotivleniye).ToString();
                    ecraN.text = "Âמכüעלוענ םא כאלןו";
                }
                if (steps == 2)
                {
                    display.text = (silatoka).ToString();
                    ecraN.text = "Àלןונלוענ םא כאלןו";
                }
                rejims = 0;
                if (steps == 3)
                {
                    display.text = (Lamp.soprotivleniye).ToString();
                    ecraN.text = "Îללוענ םא כאלןו";
                }

            }
            if (value == 1)
            {
                if (steps == 1)
                {
                    display.text = (silatoka * rez.soprotivleniye).ToString();
                    ecraN.text = "Âמכüעלוענ םא נוחטסעמנו";
                }
                if (steps == 2)
                {
                    display.text = (silatoka).ToString();
                    ecraN.text = "Àלןונלוענ םא נוחטסעמנו";
                }
                if (steps == 3)
                {
                    display.text = (rez.soprotivleniye).ToString();
                    ecraN.text = "Îללוענ םא נוחטסעמנו";
                }
                rejims = 1;

            }
        }
        else if (bs.step == false)
        {
            display.text = "8.8.8.8";
            ecraN.text = " ";
        }
    }
}
