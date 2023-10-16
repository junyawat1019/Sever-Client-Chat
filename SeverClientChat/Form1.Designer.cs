namespace SeverClientChat
{
    partial class Form1
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
            this.IP1 = new System.Windows.Forms.Label();
            this.IP2 = new System.Windows.Forms.Label();
            this.Port1 = new System.Windows.Forms.Label();
            this.Port2 = new System.Windows.Forms.Label();
            this.textIPServer = new System.Windows.Forms.TextBox();
            this.textIPClient = new System.Windows.Forms.TextBox();
            this.textPortServer = new System.Windows.Forms.TextBox();
            this.textPortClient = new System.Windows.Forms.TextBox();
            this.BtnStartSever = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.textShowMessage = new System.Windows.Forms.TextBox();
            this.textsend = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP1
            // 
            this.IP1.AutoSize = true;
            this.IP1.Location = new System.Drawing.Point(41, 51);
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(19, 16);
            this.IP1.TabIndex = 0;
            this.IP1.Text = "IP";
            // 
            // IP2
            // 
            this.IP2.AutoSize = true;
            this.IP2.Location = new System.Drawing.Point(41, 141);
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(19, 16);
            this.IP2.TabIndex = 1;
            this.IP2.Text = "IP";
            // 
            // Port1
            // 
            this.Port1.AutoSize = true;
            this.Port1.Location = new System.Drawing.Point(295, 51);
            this.Port1.Name = "Port1";
            this.Port1.Size = new System.Drawing.Size(45, 16);
            this.Port1.TabIndex = 2;
            this.Port1.Text = "PORT";
            // 
            // Port2
            // 
            this.Port2.AutoSize = true;
            this.Port2.Location = new System.Drawing.Point(295, 141);
            this.Port2.Name = "Port2";
            this.Port2.Size = new System.Drawing.Size(45, 16);
            this.Port2.TabIndex = 3;
            this.Port2.Text = "PORT";
            // 
            // textIPServer
            // 
            this.textIPServer.Location = new System.Drawing.Point(66, 48);
            this.textIPServer.Name = "textIPServer";
            this.textIPServer.Size = new System.Drawing.Size(223, 22);
            this.textIPServer.TabIndex = 4;
            // 
            // textIPClient
            // 
            this.textIPClient.Location = new System.Drawing.Point(66, 138);
            this.textIPClient.Name = "textIPClient";
            this.textIPClient.Size = new System.Drawing.Size(223, 22);
            this.textIPClient.TabIndex = 5;
            // 
            // textPortServer
            // 
            this.textPortServer.Location = new System.Drawing.Point(346, 48);
            this.textPortServer.Name = "textPortServer";
            this.textPortServer.Size = new System.Drawing.Size(181, 22);
            this.textPortServer.TabIndex = 6;
            // 
            // textPortClient
            // 
            this.textPortClient.Location = new System.Drawing.Point(346, 138);
            this.textPortClient.Name = "textPortClient";
            this.textPortClient.Size = new System.Drawing.Size(181, 22);
            this.textPortClient.TabIndex = 7;
            // 
            // BtnStartSever
            // 
            this.BtnStartSever.Location = new System.Drawing.Point(44, 76);
            this.BtnStartSever.Name = "BtnStartSever";
            this.BtnStartSever.Size = new System.Drawing.Size(483, 26);
            this.BtnStartSever.TabIndex = 8;
            this.BtnStartSever.Text = "Start Server";
            this.BtnStartSever.UseVisualStyleBackColor = true;
            this.BtnStartSever.Click += new System.EventHandler(this.BtnStartSever_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(44, 166);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(483, 26);
            this.BtnConnect.TabIndex = 10;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // textShowMessage
            // 
            this.textShowMessage.Location = new System.Drawing.Point(44, 211);
            this.textShowMessage.Multiline = true;
            this.textShowMessage.Name = "textShowMessage";
            this.textShowMessage.Size = new System.Drawing.Size(483, 172);
            this.textShowMessage.TabIndex = 11;
            this.textShowMessage.WordWrap = false;
            // 
            // textsend
            // 
            this.textsend.Location = new System.Drawing.Point(44, 389);
            this.textsend.Multiline = true;
            this.textsend.Name = "textsend";
            this.textsend.Size = new System.Drawing.Size(296, 28);
            this.textsend.TabIndex = 12;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(346, 389);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(181, 28);
            this.BtnSend.TabIndex = 13;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Server ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.textsend);
            this.Controls.Add(this.textShowMessage);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnStartSever);
            this.Controls.Add(this.textPortClient);
            this.Controls.Add(this.textPortServer);
            this.Controls.Add(this.textIPClient);
            this.Controls.Add(this.textIPServer);
            this.Controls.Add(this.Port2);
            this.Controls.Add(this.Port1);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.IP1);
            this.Name = "Form1";
            this.Text = "Chat Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IP1;
        private System.Windows.Forms.Label IP2;
        private System.Windows.Forms.Label Port1;
        private System.Windows.Forms.Label Port2;
        private System.Windows.Forms.TextBox textIPServer;
        private System.Windows.Forms.TextBox textIPClient;
        private System.Windows.Forms.TextBox textPortServer;
        private System.Windows.Forms.TextBox textPortClient;
        private System.Windows.Forms.Button BtnStartSever;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox textShowMessage;
        private System.Windows.Forms.TextBox textsend;
        private System.Windows.Forms.Button BtnSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

