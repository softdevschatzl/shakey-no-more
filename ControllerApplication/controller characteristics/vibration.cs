using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace XboxController
{
    class Program
    {
        [DllImport("XInput.dll")]
        static extern int XInputSetState(int dwUserIndex, ref XINPUT_VIBRATION pVibration);

        [StructLayout(LayoutKind.Sequential)]
        struct XINPUT_VIBRATION
        {
            public ushort wLeftMotorSpeed;
            public ushort wRightMotorSpeed;
        }

        static void Main(string[] args)
        {
            // Create a new vibration state with 0 speed set for both motors.
            XINPUT_VIBRATION vibration = new XINPUT_VIBRATION();
            vibration.wLeftMotorSpeed = 0;
            vibration.wRightMotorSpeed = 0;

            // Disable vibration on the controller.
            XInputSetState(0, ref vibration);

            Console.WriteLine("Vibration disabled on your controller.");
        }
    }
}
