using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExtendedUI
{
    [CreateAssetMenu(fileName = "New Set Radial Slider Command", menuName = "New Set Radial Slider Command")]
    public class SetRadialSliderCommand : GameLogCommand
    {
        public override void Invoke(string[] args)
        {
            base.Invoke(args);
            int value = 0;
            if (int.TryParse(args[2], out value) == false) return;

            var ob = GameObject.Find(args[1]);

            if (ob != null)
            {
                var slider = ob.GetComponent<RadialSliderTMP>();
                if(slider != null)
                {
                    slider.SetValue(value);
                }
            }
        }
    }
}
