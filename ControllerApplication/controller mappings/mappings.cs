using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace XboxController
{
    class Program
    {
        [DllImport("XInput.dll")]
        static extern int XInputGetCapabilities(int dwUserIndex, int dwFlags, ref XINPUT_CAPABILITIES pCapabilities);

        [DllImport("XInput.dll")]
        static extern int XInputGetState(int dwUserIndex, ref XINPUT_STATE pState);

        [DllImport("XInput.dll")]
        static extern int XInputSetState(int dwUserIndex, ref XINPUT_VIBRATION pVibration);

        [DllImport("XInput.dll")]
        static extern int XInputGetKeystroke(int dwUserIndex, int dwReserved, ref XINPUT_KEYSTROKE pKeystroke);

        [StructLayout(LayoutKind.Sequential)]
        struct XINPUT_CAPABILITIES
        {
            public byte Type;
            public byte SubType;
            public short Flags;
            public XINPUT_CAPABILITIES_EX XInputCapabilitiesEx;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct XINPUT_CAPABILITIES_EX
        {
            public ushort Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct XINPUT_STATE
        {
            public int PacketNumber;
            public XINPUT_GAMEPAD Gamepad;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct XINPUT_GAMEPAD
        {
            public ushort wButtons;
            public byte bLeftTrigger;
            public byte bRightTrigger;
            public short sThumbLX;
            public short sThumbLY;
            public short sThumbRX;
            public short sThumbRY;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct XINPUT_VIBRATION
        {
            public ushort wLeftMotorSpeed;
            public ushort wRightMotorSpeed;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct XINPUT_KEYSTROKE
        {
            public ushort VirtualKey;
            public ushort Unicode;
            public char Ascii;
            public ushort Flags;
            public byte UserIndex;
            public byte HidCode;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the button you want to change:");
            Console.WriteLine("1. A");
            Console.WriteLine("2. B");
            Console.WriteLine("3. X");
            Console.WriteLine("4. Y");
            Console.WriteLine("5. Left bumper");
            Console.WriteLine("6. Right bumper");
            Console.WriteLine("7. Left trigger");
            Console.WriteLine("8. Right trigger");
            Console.WriteLine("9. Back");
            Console.WriteLine("10. Start");
            Console.WriteLine("11. Left stick press");
            Console.WriteLine("12. Right stick press");
            Console.WriteLine("13. D-pad up");
            Console.WriteLine("14. D-pad down");
            Console.WriteLine("15. D-pad left");
            Console.WriteLine("16. D-pad right");

            int initialButton = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the virtual key code of the new button mapping:");
            int newButton = int.Parse(Console.ReadLine());

            // Create a new XINPUT_KEYSTROKE structure with
            // the desired change in buttons.
            switch (button)
            {
                case 1:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_A;
                    break;
                case 2:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_B;
                    break;
                case 3:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_X;
                    break;
                case 4:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_Y;
                    break;
                case 5:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_LEFT_SHOULDER;
                    break;
                case 6:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_RIGHT_SHOULDER;
                    break;
                case 7:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_LEFT_TRIGGER;
                    break;
                case 8:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_RIGHT_TRIGGER;
                    break;
                case 9:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_BACK;
                    break;
                case 10:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_START;
                    break;
                case 11:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_LEFT_THUMB;
                    break;
                case 12:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_RIGHT_THUMB;
                    break;
                case 13:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_DPAD_UP;
                    break;
                case 14:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_DPAD_DOWN;
                    break;
                case 15:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_DPAD_LEFT;
                    break;
                case 16:
                    keystroke.HidCode = (byte)XINPUT_GAMEPAD_BUTTONS.XINPUT_GAMEPAD_DPAD_RIGHT;
                    break;
                default:
                    Console.WriteLine("Invalid button selection.");
                    return;
            }

            // Set the new button mapping.
            XInputSetKeystroke(0, 0, ref keystroke);
            Console.WriteLine("Button mapping changed successfully.")
            

