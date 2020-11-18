namespace ProyekPV
{
    partial class MyAccount
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
            this.playBTN = new System.Windows.Forms.Button();
            this.userTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playBTN
            // 
            this.playBTN.Location = new System.Drawing.Point(514, 248);
            this.playBTN.Name = "playBTN";
            this.playBTN.Size = new System.Drawing.Size(178, 33);
            this.playBTN.TabIndex = 5;
            this.playBTN.Text = "Play now !!";
            this.playBTN.UseVisualStyleBackColor = true;
            this.playBTN.Click += new System.EventHandler(this.playBTN_Click);
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(514, 187);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(178, 22);
            this.userTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(440, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyekPV.Properties.Resources.background_Menu;
            this.ClientSize = new System.Drawing.Size(1200, 542);
            this.Controls.Add(this.playBTN);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.label1);
            this.Name = "MyAccount";
            this.Text = "MainBeforeGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBTN;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Label label1;
    }
}