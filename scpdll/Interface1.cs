using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace scpdll
{
    public interface Interface1
    {
         void plugin_Click(int index);
         void unplug_Click();
         void unplugAll_Click();
         bool btnA_Click();
         bool btnB_Click();
         bool btnX_Click();
         bool btnY_Click();
         bool btnUp_Click();
         bool btnLeft_Click();
         bool btnRight_Click();
         bool btnDown_Click();
         bool btnLeftBumper_Click();
         bool btnRightBumper_Click();
         bool btnXbox_Click();
         bool btnStart_Click();
         bool btnBack_Click();
         bool leftStick_Click();
         bool rightStick_Click();
         bool leftTrigger_ValueChanged(byte LeftTriggerValue);
         bool rightTrigger_ValueChanged(byte RightTriggerValue);
         bool leftStickY_ValueChanged(short LeftStickYvalue);
         bool leftStickX_ValueChanged(short LeftStickXvalue);
         bool rightStickY_ValueChanged(short RightStickYvalue);
         bool rightStickX_ValueChanged(short RightStickXvalue);
    }
}
