namespace Bunker.LoginScreen
{
    partial class BunkerLoginForm
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
            bConnect = new Button();
            tbNickname = new TextBox();
            tbIP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bConnect
            // 
            bConnect.Location = new Point(59, 152);
            bConnect.Name = "bConnect";
            bConnect.Size = new Size(131, 51);
            bConnect.TabIndex = 0;
            bConnect.Text = "Подключиться";
            bConnect.UseVisualStyleBackColor = true;
            bConnect.Click += bConnect_Click;
            // 
            // tbNickname
            // 
            tbNickname.Location = new Point(12, 36);
            tbNickname.MaxLength = 20;
            tbNickname.Name = "tbNickname";
            tbNickname.Size = new Size(231, 29);
            tbNickname.TabIndex = 1;
            // 
            // tbIP
            // 
            tbIP.Location = new Point(12, 101);
            tbIP.MaxLength = 15;
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(231, 29);
            tbIP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 2;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 2;
            label2.Text = "IPv4 сервера:";
            // 
            // BunkerLoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 215);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbIP);
            Controls.Add(tbNickname);
            Controls.Add(bConnect);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "BunkerLoginForm";
            Text = "Bunker Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bConnect;
        private TextBox tbNickname;
        private TextBox tbIP;
        private Label label1;
        private Label label2;
    }
}