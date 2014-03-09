using System;
using System.Windows.Forms;

namespace ShulePlus
{
	/// <summary>
	/// ウィンドウフッククラス
	/// </summary>
	class WindowHook : NativeWindow
	{
		/// <summary>
		/// フック対象のウィンドウハンドルを設定
		/// </summary>
		/// <param name="handle">フック対象のウィンドウハンドル</param>
		public WindowHook(IntPtr handle)
		{
			// サブクラスウィンドウの設定
			AssignHandle(handle);
		}

		/// <summary>
		/// フック対象のウィンドウプロシージャ
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
		}
	}
}
