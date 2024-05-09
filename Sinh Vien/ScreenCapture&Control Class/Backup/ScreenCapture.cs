using System; 
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Net.Sockets;


	public class ScreenCapture : System.MarshalByRefObject
	{

		[DllImport("user32.dll")]
		private static extern IntPtr GetDesktopWindow();

		[DllImport("gdi32.dll")]
		private static extern bool BitBlt(
			IntPtr hdcDest, // handle to destination DC
			int nXDest, // x-coord of destination upper-left corner
			int nYDest, // y-coord of destination upper-left corner
			int nWidth, // width of destination rectangle
			int nHeight, // height of destination rectangle
			IntPtr hdcSrc, // handle to source DC
			int nXSrc, // x-coordinate of source upper-left corner
			int nYSrc, // y-coordinate of source upper-left corner
			System.Int32 dwRop // raster operation code
			);

		private const Int32 SRCCOPY = 0xCC0020;

		[DllImport("user32.dll")]
		private static extern int GetSystemMetrics(int nIndex);

		private const int SM_CXSCREEN = 0;
		private const int SM_CYSCREEN = 1;

		public Size GetDesktopBitmapSize()
		{
			return new Size(GetSystemMetrics(SM_CXSCREEN), GetSystemMetrics(SM_CYSCREEN));
		}

		private const uint MOUSEEVENTF_MOVE       = 0x0001; /* mouse move */
		private const uint MOUSEEVENTF_LEFTDOWN   = 0x0002; /* left button down */
		private const uint MOUSEEVENTF_LEFTUP     = 0x0004; /* left button up */
		private const uint MOUSEEVENTF_RIGHTDOWN  = 0x0008; /* right button down */
		private const uint MOUSEEVENTF_RIGHTUP    = 0x0010; /* right button up */
		private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
		private const uint MOUSEEVENTF_MIDDLEUP   = 0x0040; /* middle button up */
		private const uint MOUSEEVENTF_WHEEL      = 0x0800; /* wheel button rolled */
		private const uint MOUSEEVENTF_ABSOLUTE   = 0x8000; /* absolute move */
		private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
		private const uint KEYEVENTF_KEYUP       = 0x0002;
		private const uint INPUT_MOUSE    = 0;
		private const uint INPUT_KEYBOARD = 1;

		struct MOUSE_INPUT
		{
			public uint dx;
			public uint dy;
			public uint mouseData;
			public uint dwFlags;
			public uint time;
			public uint dwExtraInfo;
		}

		struct KEYBD_INPUT
		{
			public ushort wVk;
			public ushort wScan;
			public uint   dwFlags;
			public uint   time;
			public uint   dwExtraInfo;
		}

		[StructLayout(LayoutKind.Explicit)]
			struct INPUT
		{
			[FieldOffset(0)]
			public uint type;

			// union
			[FieldOffset(4)]
			public MOUSE_INPUT mi;

			[FieldOffset(4)]
			public KEYBD_INPUT ki;
		}

		[DllImport("user32.dll")]
		private static extern uint SendInput(
			uint nInputs,     // count of input events
			ref INPUT input,
			int cbSize        // size of structure
			);

		public void PressOrReleaseMouseButton(bool Press, bool Left, int X, int Y)
		{
			INPUT input = new INPUT();

			input.type           = INPUT_MOUSE;
			input.mi.dx          = (uint) X;
			input.mi.dy          = (uint) Y;
			input.mi.mouseData   = 0;
			input.mi.dwFlags     = 0;
			input.mi.time        = 0;
			input.mi.dwExtraInfo = 0;

			if (Left)
			{
				input.mi.dwFlags = Press ? MOUSEEVENTF_LEFTDOWN : MOUSEEVENTF_LEFTUP;
			}
			else
			{
				input.mi.dwFlags = Press ? MOUSEEVENTF_RIGHTDOWN : MOUSEEVENTF_RIGHTUP;
			}

			SendInput(1, ref input, Marshal.SizeOf(input));
		}

		[DllImport("user32.dll")]
		private static extern void SetCursorPos(int x, int y);

		public void MoveMouse(int x, int y)
		{
			SetCursorPos(x, y);
		}

		public void SendKeystroke(byte VirtualKeyCode, byte ScanCode, bool KeyDown, bool ExtendedKey)
		{
			INPUT input = new INPUT();

			input.type           = INPUT_KEYBOARD;
			input.ki.wVk         = VirtualKeyCode;
			input.ki.wScan       = ScanCode;
			input.ki.dwExtraInfo = 0;
			input.ki.time        = 0;

			if (!KeyDown)
			{
				input.ki.dwFlags |= KEYEVENTF_KEYUP;
			}

			if (ExtendedKey)
			{
				input.ki.dwFlags |= KEYEVENTF_EXTENDEDKEY;
			}

			SendInput(1, ref input, Marshal.SizeOf(input));
		}

		public byte[] GetDesktopBitmapBytes()
		{
			Size DesktopBitmapSize = GetDesktopBitmapSize();
			Graphics Graphic = Graphics.FromHwnd(GetDesktopWindow());
			Bitmap MemImage = new Bitmap(DesktopBitmapSize.Width, DesktopBitmapSize.Height, Graphic);
			
			Graphics MemGraphic = Graphics.FromImage(MemImage);
			IntPtr dc1 = Graphic.GetHdc();
			IntPtr dc2 = MemGraphic.GetHdc();
			BitBlt(dc2, 0, 0, DesktopBitmapSize.Width, DesktopBitmapSize.Height, dc1, 0, 0, SRCCOPY);
			Graphic.ReleaseHdc(dc1);
			MemGraphic.ReleaseHdc(dc2);
			Graphic.Dispose();
			MemGraphic.Dispose();

			Graphics g = System.Drawing.Graphics.FromImage(MemImage);
			System.Windows.Forms.Cursor cur = System.Windows.Forms.Cursors.Arrow;
			cur.Draw(g,new Rectangle(System.Windows.Forms.Cursor.Position.X-10,System.Windows.Forms.Cursor.Position.Y-10,cur.Size.Width,cur.Size.Height));

			MemoryStream ms = new MemoryStream();
			MemImage.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
			return ms.GetBuffer();
		}


		} 
