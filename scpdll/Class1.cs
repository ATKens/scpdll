using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScpDriverInterface;



namespace scpdll
{
    public class Class1:Interface1
    {
        public ScpBus scpBus = new ScpBus();
        public X360Controller controller = new X360Controller();
        public byte[] outputReport = new byte[8];
        public Stack<int> StaArray = new Stack<int>();

        public byte[] _outputReport = new byte[8];
        public bool _rumbleValid = false;
        public byte _bigRumble = 0;
        public byte _smallRumble = 0;

        public  void  plugin_Click(int index)
        {
            StaArray.Push(index);
            
            scpBus.PlugIn(StaArray.Peek());
        }

        public void unplug_Click()
        {
            bool result = scpBus.Unplug(StaArray.Peek());

            StaArray.Pop();

            if (result)
            {
                controller = new X360Controller();

            }
        }

        public void unplugAll_Click()
        {
            bool result = scpBus.UnplugAll();

            StaArray.Clear();

            if (result)
            {
                controller = new X360Controller();
            
            }
        }

        public bool btnA_Click()
        {

            controller.Buttons ^= X360Buttons.A;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result; 
        }

        public bool btnB_Click()
        {

            controller.Buttons ^= X360Buttons.B;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnX_Click()
        {
            controller.Buttons ^= X360Buttons.X;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnY_Click()
        {
            controller.Buttons ^= X360Buttons.Y;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnUp_Click()
        {
            controller.Buttons ^= X360Buttons.Up;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnLeft_Click()
        {
            controller.Buttons ^= X360Buttons.Left;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnRight_Click()
        {
            controller.Buttons ^= X360Buttons.Right;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnDown_Click()
        {
            controller.Buttons ^= X360Buttons.Down;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnLeftBumper_Click()
        {
            controller.Buttons ^= X360Buttons.LeftBumper;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnRightBumper_Click()
        {
            controller.Buttons ^= X360Buttons.RightBumper;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }


        public bool btnXbox_Click()
        {

            controller.Buttons ^= X360Buttons.Logo;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }


        public bool btnStart_Click()
        {
            controller.Buttons ^= X360Buttons.Start;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool btnBack_Click()
        {
            controller.Buttons ^= X360Buttons.Back;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }


        public bool leftStick_Click()
        {
            controller.Buttons ^= X360Buttons.LeftStick;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }

        public bool rightStick_Click()
        {
            controller.Buttons ^= X360Buttons.RightStick;
            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);
            CheckRumble();
            return result;
        }



        public bool leftTrigger_ValueChanged(byte LeftTriggerValue)
        {


            controller.LeftTrigger = LeftTriggerValue;

            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);

            return result;
        }


        public bool rightTrigger_ValueChanged(byte RightTriggerValue)
        {
           

            controller.RightTrigger = RightTriggerValue;

            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);

            return result;
        }


        public bool leftStickY_ValueChanged(short LeftStickYvalue)
        {
            

            controller.LeftStickY = LeftStickYvalue;

            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);

            return result;
        }

        public bool leftStickX_ValueChanged(short LeftStickXvalue)
        {
        
            controller.LeftStickX = LeftStickXvalue;

            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);

            return result;
        }

        public bool rightStickY_ValueChanged(short RightStickYvalue)
        {
         
            controller.RightStickY = RightStickYvalue;

            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);

            return result;
        }

        public bool rightStickX_ValueChanged(short RightStickXvalue)
        {
           
            controller.RightStickX = RightStickXvalue;

            bool result = scpBus.Report(StaArray.Peek(), controller.GetReport(), outputReport);

            return result;
        }



        public void CheckRumble()
        {
            if (_outputReport[1] == 0x08)
            {
                _bigRumble = _outputReport[3];
                _smallRumble = _outputReport[4];
                _rumbleValid = true;
            }
        }


    }
}
