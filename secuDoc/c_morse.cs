using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace secuDoc
{
    class c_morse
    {
        public enum btns {
            CAPS,
            NUM,
            SCROLL
        }

        public static btns buttonToUse = btns.CAPS;

        private static bool caps_on = false;
        private static bool num_on = false;
        private static bool scroll_on = false;

        private const byte VK_CAPS = 0x14;
        private const byte VK_NUM = 0x90;
        private const byte VK_SCROLL = 0x91;
        private const uint KEYEVENTF_KEYUP = 0x2;

        /// <summary>
        /// Set which button to use: 0=CAPS, 1=NUM, 2=SCROLL
        /// </summary>
        /// <param name="b">button to use: 0=CAPS, 1=NUM, 2=SCROLL</param>
        public void setBTN(int b)
        {
            switch (b)
            {
                case 0:
                    buttonToUse = btns.CAPS;
                    break;

                case 1:
                    buttonToUse = btns.NUM;
                    break;

                case 2:
                    buttonToUse = btns.SCROLL;
                    break;
            }
        }
        

        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "GetKeyState", SetLastError = true)]
        static extern short GetKeyState(uint nVirtKey);

        public void doSet(bool on)
        {
            SetKey(on);
        }

        public static void SetKey(bool newState)
        {
            bool on = false;

            switch (buttonToUse)
            {
                case btns.CAPS:
                    on = GetKeyState(VK_CAPS) != 0;
                    if (on != newState)
                    {
                        keybd_event(VK_CAPS, 0, 0, 0);
                        keybd_event(VK_CAPS, 0, KEYEVENTF_KEYUP, 0);
                    }
                    break;

                case btns.NUM:
                    on = GetKeyState(VK_NUM) != 0;
                    if (on != newState)
                    {
                        keybd_event(VK_NUM, 0, 0, 0);
                        keybd_event(VK_NUM, 0, KEYEVENTF_KEYUP, 0);
                    }
                    break;

                case btns.SCROLL:
                    on = GetKeyState(VK_SCROLL) != 0;
                    if (on != newState)
                    {
                        keybd_event(VK_SCROLL, 0, 0, 0);
                        keybd_event(VK_SCROLL, 0, KEYEVENTF_KEYUP, 0);
                    }
                    break;
            }
        }

        public static void GetScrollLockState() // true = set, false = not set
        {
            scroll_on = GetKeyState(VK_SCROLL) != 0;
            caps_on = GetKeyState(VK_SCROLL) != 0;
            num_on = GetKeyState(VK_SCROLL) != 0;
        }
    }
}
