namespace ShulePlus
{
	partial class ShulePlusForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxWindowTitle = new System.Windows.Forms.TextBox();
			this.buttonSearchWindow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxWindowTitle
			// 
			this.textBoxWindowTitle.Location = new System.Drawing.Point(12, 12);
			this.textBoxWindowTitle.Name = "textBoxWindowTitle";
			this.textBoxWindowTitle.Size = new System.Drawing.Size(260, 19);
			this.textBoxWindowTitle.TabIndex = 0;
			// 
			// buttonSearchWindow
			// 
			this.buttonSearchWindow.Location = new System.Drawing.Point(12, 37);
			this.buttonSearchWindow.Name = "buttonSearchWindow";
			this.buttonSearchWindow.Size = new System.Drawing.Size(84, 23);
			this.buttonSearchWindow.TabIndex = 1;
			this.buttonSearchWindow.Text = "ウィンドウ検索開始";
			this.buttonSearchWindow.UseVisualStyleBackColor = true;
			this.buttonSearchWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSearchWindow_MouseDown);
			// 
			// ShulePlusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.buttonSearchWindow);
			this.Controls.Add(this.textBoxWindowTitle);
			this.Name = "ShulePlusForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.ShulePlusForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxWindowTitle;
		private System.Windows.Forms.Button buttonSearchWindow;
	}
}

