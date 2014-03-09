using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ShulePlus
{
	public partial class ShulePlusForm : Form
	{
		/// <summary>
		/// ウィンドウサーチ中か
		/// </summary>
		bool windowSearching = false;

		/// <summary>
		/// フック対象のウィンドウハンドル
		/// </summary>
		IntPtr hookWindowHandle = IntPtr.Zero;

		/// <summary>
		/// 現在マウス位置にあるウィンドウハンドル
		/// </summary>
		IntPtr nowWindowHandle = IntPtr.Zero;

		public ShulePlusForm()
		{
			InitializeComponent();
		}

		private void ShulePlusForm_Load(object sender, System.EventArgs e)
		{
			MouseHook mouseHook = new MouseHook();
			mouseHook.MouseHooked += (_sender, _e) =>
			{
				if (!windowSearching)
				{
					return;
				}

				if (_e.Message == MouseMessage.LUp)
				{
					hookWindowHandle = nowWindowHandle;
					HookWindow(hookWindowHandle);
					windowSearching = false;
				}

				if (_e.Message == MouseMessage.Move)
				{
					IntPtr handle = GetWindowHandle();
					nowWindowHandle = handle;

					StringBuilder str = new StringBuilder(256);
					GetWindowText(handle, str, 256);
					textBoxWindowTitle.Text = str.ToString();
				}
			};
		}

		private void HookWindow(IntPtr handle)
		{
			// ウィンドウフック
			WindowHook hook = new WindowHook(handle);
			hook.WindowProc += (_sender, _e) =>
			{
				Message message = (_e as WindowProcEventArgs).Message;
				WindowsMessage winmessage = (WindowsMessage)message.Msg;
				System.Console.WriteLine("Msg : {0}\t{1}\t{2}", winmessage, message.WParam, message.LParam);
			};
		}

		private IntPtr GetWindowHandle()
		{
			// マウスポジションの取得
			Rectangle screen = Screen.GetBounds(this);
			int mouseX = Control.MousePosition.X;
			int mouseY = Control.MousePosition.Y;

			POINT bottomPoint;
			bottomPoint.x = mouseX;
			bottomPoint.y = mouseY;

			IntPtr handle = WindowFromPoint(bottomPoint);
			return handle;
		}

		/// <summary>
		/// 座標を含むウインドウのハンドルを取得
		/// </summary>
		/// <param name="Point">調査する座標</param>
		/// <returns>ポイントにウインドウがなければNULL</returns>
		[DllImport("user32.dll")]
		public static extern IntPtr WindowFromPoint(POINT Point);

		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{
			public int x;
			public int y;
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		private void buttonSearchWindow_MouseDown(object sender, MouseEventArgs e)
		{
			windowSearching = true;
		}
	}
}
