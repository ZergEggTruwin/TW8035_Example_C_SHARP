using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TW8035_C_SHARP
{
    public partial class Form1
    {
        public const int WM_COMM_RX_DATA = 0x4000 + 11;
        public const int WM_COMM_RECV_INFO = 0x4000 + 41;
        public const int WM_COMM_RX_TEMP_DATA = 0x4000 + 13;

        public struct TW_8035_ImageData
        {
            [MarshalAs(UnmanagedType.U1, SizeConst = 1)]
            public byte FPS;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort ImageWidth;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort ImageHeight;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort VCM;
            [MarshalAs(UnmanagedType.R4, SizeConst = 4)]
            public float TempSensor;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort TempMcu;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort TempBoard;
            [MarshalAs(UnmanagedType.U4)]
            public UInt32 cnt;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4800)]
            public ushort[] ImageData;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort T_Data1;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort T_Data2;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort T_Data3;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort RadioOffset;
        }

        public struct TW_8035_TempData
        {
            [MarshalAs(UnmanagedType.U4)]
            public UInt32 cnt;
            [MarshalAs(UnmanagedType.U1, SizeConst = 1)]
            public byte FPS;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort ImageWidth;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort ImageHeight;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort VCM;
            [MarshalAs(UnmanagedType.R4, SizeConst = 4)]
            public float TempSensor;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort TempMcu;
            [MarshalAs(UnmanagedType.U2, SizeConst = 2)]
            public ushort TempBoard;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4800)]
            public float[] TempData;
        }

        public struct TW_8035_DeviceData
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string FlashDate;
            [MarshalAs(UnmanagedType.LPStr)]
            public string DeviceType;
            [MarshalAs(UnmanagedType.LPStr)]
            public string DataType;
            [MarshalAs(UnmanagedType.LPStr)]
            public string SaveDate;
            [MarshalAs(UnmanagedType.LPStr)]
            public string InlineSerial;
            [MarshalAs(UnmanagedType.LPStr)]
            public string DeviceHWVer;
            [MarshalAs(UnmanagedType.LPStr)]
            public string DeviceSWVer;
        } // struct

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static int test1();

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static IntPtr getPortListForCSharp(int type);

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool serialPortConnectWrapper(IntPtr hWnd, IntPtr portNo);

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool serialPortCloseWrapper(IntPtr hWnd);

        [DllImport("TW8035_DLL.dll")]
        extern public static void requestDeviceInfo();

        [DllImport("TW8035_DLL.dll")]
        extern public static bool isConnected();

        [DllImport("TW8035_DLL.dll")]
        extern public static bool requestOneFrame();

        [DllImport("TW8035_DLL.dll")]
        extern public static bool requestRunStreamingMode();

        [DllImport("TW8035_DLL.dll")]
        extern public static bool requestStop();

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool changeFPSCmd(char fpsNumber);

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool requestImageConvert(char flip, char mirror);

        [DllImport("TW8035_DLL.dll")]
        extern public static float getEmissivity();

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool setEmissivity(float emissivity);

        [DllImport("TW8035_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static bool sendMode(int c);

        [DllImport("TW8035_DLL.dll")]
        extern public static void requestReset();
        
        [DllImport("TW8035_DLL.dll")]
        extern public static void setShutterOnOff(bool tf);
    }
}
