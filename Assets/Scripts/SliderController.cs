using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;


public class SliderController : MonoBehaviour
{
   public Slider myslider;
   public TMP_Text scoreTMP;
   public int score;

   void Update()

    {
        Match m = Regex.Match(scoreTMP.text, @"\d+");
        if (m.Success && int.TryParse(m.Value, out score))
        {
            myslider.value = score;
        }
    }
}
