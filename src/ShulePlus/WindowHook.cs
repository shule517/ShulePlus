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
		/// ウィンドウプロシージャイベント
		/// </summary>
		public event EventHandler WindowProc = delegate { };

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
		/// <param name="m">メッセージ</param>
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			WindowProc(this, new WindowProcEventArgs(m));
		}
	}

	/// <summary>
	/// ウィンドウプロシージャイベント引数
	/// </summary>
	class WindowProcEventArgs : EventArgs
	{
		public WindowProcEventArgs(Message message)
		{
			this.Message = message;
		}
		
		public Message Message { get; private set; }
	}
}
