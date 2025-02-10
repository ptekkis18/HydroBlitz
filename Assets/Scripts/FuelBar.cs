using System.Data.Common;
using UnityEngine;
using UnityEngine.UI;
public class FuelBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    
    public void setMaxFuel(int fuel){
        slider.maxValue =fuel;
        slider.value = fuel;

        fill.color = gradient.Evaluate(1f);
    }
   public void SetFuel(int fuel){
        slider.value = fuel;
        fill.color = gradient.Evaluate(slider.normalizedValue);
   }
   
   public void setGradient(Gradient newGrad){
    gradient = newGrad;
    fill.color = gradient.Evaluate(slider.normalizedValue);
   }
   
}
