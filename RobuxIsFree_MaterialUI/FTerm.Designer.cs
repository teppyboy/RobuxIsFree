namespace RobuxIsFree
{
    partial class FTerm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTerm));
            this.ftermm = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ftermm
            // 
            this.ftermm.BackColor = System.Drawing.Color.Black;
            this.ftermm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftermm.Font = new System.Drawing.Font("Consolas", 10F);
            this.ftermm.ForeColor = System.Drawing.Color.White;
            this.ftermm.Location = new System.Drawing.Point(0, 0);
            this.ftermm.Name = "ftermm";
            this.ftermm.ReadOnly = true;
            this.ftermm.Size = new System.Drawing.Size(791, 445);
            this.ftermm.TabIndex = 0;
            this.ftermm.Text = "-WTernimal 1.0- by teppyboy\n------------------------\n|GNU/Linux Terminal 1.0|\n---" +
    "---------------------\nTo show more commands, type help -a\n";
            // 
            // FTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 445);
            this.Controls.Add(this.ftermm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal : root@glemu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FTerm_FormClosing);
            this.Load += new System.EventHandler(this.FTerm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ftermm;
        private System.Windows.Forms.Timer timer1;
    }
}