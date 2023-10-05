using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace Keyboard_clicker_windows_by_rafalek__WinForms_
{
    public enum KeyCodes
    {
        //Math Functions
        Multiply = VirtualKeyCode.MULTIPLY,
        Add = VirtualKeyCode.ADD,
        Subtract = VirtualKeyCode.SUBTRACT,
        Divide = VirtualKeyCode.DIVIDE,

        //Function Keys
        F1 = VirtualKeyCode.F1,
        F2 = VirtualKeyCode.F2,
        F3 = VirtualKeyCode.F3,
        F4 = VirtualKeyCode.F4,
        F5 = VirtualKeyCode.F5,
        F6 = VirtualKeyCode.F6,
        F7 = VirtualKeyCode.F7,
        F8 = VirtualKeyCode.F8,
        F9 = VirtualKeyCode.F9,
        F10 = VirtualKeyCode.F10,
        F11 = VirtualKeyCode.F11,
        F12 = VirtualKeyCode.F12,

        //KEYS
        N0 = VirtualKeyCode.VK_0,
        N1 = VirtualKeyCode.VK_1,
        N2 = VirtualKeyCode.VK_2,
        N3 = VirtualKeyCode.VK_3,
        N4 = VirtualKeyCode.VK_4,
        N5 = VirtualKeyCode.VK_5,
        N6 = VirtualKeyCode.VK_6,
        N7 = VirtualKeyCode.VK_7,
        N8 = VirtualKeyCode.VK_8,
        N9 = VirtualKeyCode.VK_9,
        A = VirtualKeyCode.VK_A,
        B = VirtualKeyCode.VK_B,
        C = VirtualKeyCode.VK_C,
        D = VirtualKeyCode.VK_D,
        E = VirtualKeyCode.VK_E,
        F = VirtualKeyCode.VK_F,
        G = VirtualKeyCode.VK_G,
        H = VirtualKeyCode.VK_H,
        I = VirtualKeyCode.VK_I,
        J = VirtualKeyCode.VK_J,
        K = VirtualKeyCode.VK_K,
        L = VirtualKeyCode.VK_L,
        M = VirtualKeyCode.VK_M,
        N = VirtualKeyCode.VK_N,
        O = VirtualKeyCode.VK_O,
        P = VirtualKeyCode.VK_P,
        Q = VirtualKeyCode.VK_Q,
        R = VirtualKeyCode.VK_R,
        S = VirtualKeyCode.VK_S,
        T = VirtualKeyCode.VK_T,
        U = VirtualKeyCode.VK_U,
        V = VirtualKeyCode.VK_V,
        W = VirtualKeyCode.VK_W,
        X = VirtualKeyCode.VK_X,
        Y = VirtualKeyCode.VK_Y,
        Z = VirtualKeyCode.VK_Z,

        //Specials
        Tab = VirtualKeyCode.TAB,
        CapsLock = VirtualKeyCode.CAPITAL,
        Alt = VirtualKeyCode.MENU,
        Shift = VirtualKeyCode.SHIFT,
        Ctrl = VirtualKeyCode.CONTROL,
        Enter = VirtualKeyCode.RETURN,
        Backspace = VirtualKeyCode.BACK,
        ESC = VirtualKeyCode.ESCAPE,
        Space = VirtualKeyCode.SPACE
    }
}
