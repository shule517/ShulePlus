using System.Windows.Forms;

namespace ShulePlus
{
	public partial class ShulePlusForm : Form
	{
		public ShulePlusForm()
		{
			InitializeComponent();
		}

		private void ShulePlusForm_Load(object sender, System.EventArgs e)
		{
			WindowHook hook = new WindowHook(this.Handle);
			hook.WindowProc += (_sender, _e) =>
			{
				Message message = (_e as WindowProcEventArgs).Message;
				WindowsMessage winmessage = (WindowsMessage)message.Msg;

				System.Console.WriteLine("Msg : {0}\t{1}\t{2}", winmessage, message.WParam, message.LParam);
			};
		}
	}
}
