namespace Bunker_Server
{
    partial class BunkerServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbNetLogs = new ListBox();
            lClientAmountName = new Label();
            bStart = new Button();
            lClientAmount = new Label();
            lStatusName = new Label();
            lStatus = new Label();
            worker_listener = new System.Windows.Forms.Timer(components);
            worker_keepalive = new System.Windows.Forms.Timer(components);
            worker_readasync = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbNetLogs
            // 
            lbNetLogs.FormattingEnabled = true;
            lbNetLogs.HorizontalScrollbar = true;
            lbNetLogs.ItemHeight = 21;
            lbNetLogs.Location = new Point(12, 12);
            lbNetLogs.Name = "lbNetLogs";
            lbNetLogs.Size = new Size(363, 361);
            lbNetLogs.TabIndex = 0;
            // 
            // lClientAmountName
            // 
            lClientAmountName.AutoSize = true;
            lClientAmountName.Location = new Point(381, 288);
            lClientAmountName.Name = "lClientAmountName";
            lClientAmountName.Size = new Size(74, 21);
            lClientAmountName.TabIndex = 1;
            lClientAmountName.Text = "Игроков:";
            // 
            // bStart
            // 
            bStart.Location = new Point(381, 319);
            bStart.Name = "bStart";
            bStart.Size = new Size(118, 54);
            bStart.TabIndex = 2;
            bStart.Text = "Начать игру";
            bStart.UseVisualStyleBackColor = true;
            // 
            // lClientAmount
            // 
            lClientAmount.AutoSize = true;
            lClientAmount.Location = new Point(461, 288);
            lClientAmount.Name = "lClientAmount";
            lClientAmount.Size = new Size(19, 21);
            lClientAmount.TabIndex = 1;
            lClientAmount.Text = "0";
            // 
            // lStatusName
            // 
            lStatusName.AutoSize = true;
            lStatusName.Location = new Point(381, 267);
            lStatusName.Name = "lStatusName";
            lStatusName.Size = new Size(60, 21);
            lStatusName.TabIndex = 1;
            lStatusName.Text = "Статус:";
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Location = new Point(447, 267);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(145, 21);
            lStatus.TabIndex = 1;
            lStatus.Text = "ожидание игроков";
            // 
            // worker_listener
            // 
            worker_listener.Enabled = true;
            worker_listener.Interval = 50;
            worker_listener.Tick += worker_listener_Tick;
            // 
            // worker_keepalive
            // 
            worker_keepalive.Enabled = true;
            worker_keepalive.Interval = 3000;
            worker_keepalive.Tick += worker_keepalive_Tick;
            // 
            // worker_readasync
            // 
            worker_readasync.Enabled = true;
            worker_readasync.Interval = 50;
            worker_readasync.Tick += worker_readasync_Tick;
            // 
            // BunkerServerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 388);
            Controls.Add(bStart);
            Controls.Add(lClientAmount);
            Controls.Add(lStatus);
            Controls.Add(lStatusName);
            Controls.Add(lClientAmountName);
            Controls.Add(lbNetLogs);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "BunkerServerForm";
            Text = "Bunker Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbNetLogs;
        private Label lClientAmountName;
        private Button bStart;
        private Label lClientAmount;
        private Label lStatusName;
        private Label lStatus;
        private System.Windows.Forms.Timer worker_listener;
        private System.Windows.Forms.Timer worker_keepalive;
        private System.Windows.Forms.Timer worker_readasync;
    }
}
