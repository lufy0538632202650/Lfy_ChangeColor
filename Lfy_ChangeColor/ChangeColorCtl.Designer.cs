namespace Lfy_ChangeColor
{
    partial class Ctl_ColorChange
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.Ctl_Lbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Ctl_Lbl
			// 
			this.Ctl_Lbl.AutoSize = true;
			this.Ctl_Lbl.Location = new System.Drawing.Point(4, 4);
			this.Ctl_Lbl.Name = "Ctl_Lbl";
			this.Ctl_Lbl.Size = new System.Drawing.Size(0, 12);
			this.Ctl_Lbl.TabIndex = 0;
			// 
			// Ctl_ColorChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.Controls.Add(this.Ctl_Lbl);
			this.Name = "Ctl_ColorChange";
			this.Size = new System.Drawing.Size(40, 40);
			this.Load += new System.EventHandler(this.Ctl_ColorChange_Load);
			this.Click += new System.EventHandler(this.ColorChange_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label Ctl_Lbl;
	}
}
