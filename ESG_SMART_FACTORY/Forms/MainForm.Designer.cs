namespace ESG_SMART_FACTORY
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Top_bar = new System.Windows.Forms.Panel();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.Side_bar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Realtime_ppm_pl = new System.Windows.Forms.Panel();
            this.Temperature_pl = new System.Windows.Forms.Panel();
            this.Humidity_pl = new System.Windows.Forms.Panel();
            this.Threshold_alarm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Top_bar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_bar
            // 
            this.Top_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.Top_bar.Controls.Add(this.Title_lbl);
            this.Top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_bar.Location = new System.Drawing.Point(0, 0);
            this.Top_bar.Name = "Top_bar";
            this.Top_bar.Size = new System.Drawing.Size(1456, 86);
            this.Top_bar.TabIndex = 0;
            // 
            // Title_lbl
            // 
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Title_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title_lbl.Location = new System.Drawing.Point(21, 32);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(270, 26);
            this.Title_lbl.TabIndex = 0;
            this.Title_lbl.Text = "Hazardous Gas Monitoring";
            // 
            // Side_bar
            // 
            this.Side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_bar.Location = new System.Drawing.Point(0, 86);
            this.Side_bar.Name = "Side_bar";
            this.Side_bar.Size = new System.Drawing.Size(206, 680);
            this.Side_bar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Realtime_ppm_pl
            // 
            this.Realtime_ppm_pl.Location = new System.Drawing.Point(232, 116);
            this.Realtime_ppm_pl.Name = "Realtime_ppm_pl";
            this.Realtime_ppm_pl.Size = new System.Drawing.Size(362, 315);
            this.Realtime_ppm_pl.TabIndex = 3;
            // 
            // Temperature_pl
            // 
            this.Temperature_pl.Location = new System.Drawing.Point(621, 116);
            this.Temperature_pl.Name = "Temperature_pl";
            this.Temperature_pl.Size = new System.Drawing.Size(167, 135);
            this.Temperature_pl.TabIndex = 4;
            // 
            // Humidity_pl
            // 
            this.Humidity_pl.Location = new System.Drawing.Point(809, 116);
            this.Humidity_pl.Name = "Humidity_pl";
            this.Humidity_pl.Size = new System.Drawing.Size(154, 135);
            this.Humidity_pl.TabIndex = 5;
            // 
            // Threshold_alarm
            // 
            this.Threshold_alarm.Location = new System.Drawing.Point(621, 268);
            this.Threshold_alarm.Name = "Threshold_alarm";
            this.Threshold_alarm.Size = new System.Drawing.Size(342, 162);
            this.Threshold_alarm.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(988, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 313);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(232, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 281);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(809, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 290);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(364, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 290);
            this.panel4.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1456, 766);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Threshold_alarm);
            this.Controls.Add(this.Humidity_pl);
            this.Controls.Add(this.Temperature_pl);
            this.Controls.Add(this.Realtime_ppm_pl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Side_bar);
            this.Controls.Add(this.Top_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Top_bar.ResumeLayout(false);
            this.Top_bar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Top_bar;
        private System.Windows.Forms.Panel Side_bar;
        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Realtime_ppm_pl;
        private System.Windows.Forms.Panel Temperature_pl;
        private System.Windows.Forms.Panel Humidity_pl;
        private System.Windows.Forms.Panel Threshold_alarm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

