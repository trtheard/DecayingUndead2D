using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RainBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxSalve(int salveInt){
        slider.maxValue = salveInt;
        slider.value = salveInt;
    }

    //Get the integer from the Rain Bar slider in the inspector.
    public void SetSalve(int salveInt){
        slider.value = salveInt;
    }
}
