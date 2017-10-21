using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Observer
{
    class SystemWideHotKey
    {
        public static int MOD_ALT = 0x1;
        public static int MOD_CONTROL = 0x2;
        public static int MOD_SHIFT = 0x4;
        public static int MOD_WIN = 0x8;
        public static int WM_HOTKEY = 0x312;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private static int keyId;
        public static void RegisterHotKey(Form _inForm, Keys _inKey)
        {
            int modifiers = 0;

            if ((_inKey & Keys.Alt) == Keys.Alt)
                modifiers = modifiers | SystemWideHotKey.MOD_ALT;

            if ((_inKey & Keys.Control) == Keys.Control)
                modifiers = modifiers | SystemWideHotKey.MOD_CONTROL;

            if ((_inKey & Keys.Shift) == Keys.Shift)
                modifiers = modifiers | SystemWideHotKey.MOD_SHIFT;

            Keys k = _inKey & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;

            DelegateFunction DelegMethod = delegate ()
            {
                keyId = _inForm.GetHashCode();
                RegisterHotKey((IntPtr)_inForm.Handle, keyId, modifiers, (int)k);
            };

            _inForm.Invoke(DelegMethod);
        }

        private delegate void DelegateFunction();

        public static void UnregisterHotKey(Form _inForm)
        {
            try
            {
                DelegateFunction df = delegate ()
                {
                    UnregisterHotKey(_inForm.Handle, keyId);
                };

                _inForm.Invoke(df);
            }
            catch { }
        }
    }
}
