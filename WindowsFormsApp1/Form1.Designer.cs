
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.chkFire0 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFire9 = new System.Windows.Forms.CheckBox();
            this.chkFire8 = new System.Windows.Forms.CheckBox();
            this.chkFire7 = new System.Windows.Forms.CheckBox();
            this.chkFire6 = new System.Windows.Forms.CheckBox();
            this.chkFire5 = new System.Windows.Forms.CheckBox();
            this.chkFire4 = new System.Windows.Forms.CheckBox();
            this.chkFire3 = new System.Windows.Forms.CheckBox();
            this.chkFire2 = new System.Windows.Forms.CheckBox();
            this.chkFire1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPA9 = new System.Windows.Forms.CheckBox();
            this.chkPA8 = new System.Windows.Forms.CheckBox();
            this.chkPA7 = new System.Windows.Forms.CheckBox();
            this.chkPA6 = new System.Windows.Forms.CheckBox();
            this.chkPA5 = new System.Windows.Forms.CheckBox();
            this.chkPA4 = new System.Windows.Forms.CheckBox();
            this.chkPA3 = new System.Windows.Forms.CheckBox();
            this.chkPA2 = new System.Windows.Forms.CheckBox();
            this.chkPA1 = new System.Windows.Forms.CheckBox();
            this.chkPA0 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seq.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "수신지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "송신지";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(689, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(552, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(552, 21);
            this.textBox3.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(39, 257);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(607, 161);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // chkFire0
            // 
            this.chkFire0.AutoSize = true;
            this.chkFire0.Location = new System.Drawing.Point(19, 20);
            this.chkFire0.Name = "chkFire0";
            this.chkFire0.Size = new System.Drawing.Size(58, 16);
            this.chkFire0.TabIndex = 4;
            this.chkFire0.Text = "0 호차";
            this.chkFire0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFire9);
            this.groupBox1.Controls.Add(this.chkFire8);
            this.groupBox1.Controls.Add(this.chkFire7);
            this.groupBox1.Controls.Add(this.chkFire6);
            this.groupBox1.Controls.Add(this.chkFire5);
            this.groupBox1.Controls.Add(this.chkFire4);
            this.groupBox1.Controls.Add(this.chkFire3);
            this.groupBox1.Controls.Add(this.chkFire2);
            this.groupBox1.Controls.Add(this.chkFire1);
            this.groupBox1.Controls.Add(this.chkFire0);
            this.groupBox1.Location = new System.Drawing.Point(35, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "화재 감지";
            // 
            // chkFire9
            // 
            this.chkFire9.AutoSize = true;
            this.chkFire9.Location = new System.Drawing.Point(595, 20);
            this.chkFire9.Name = "chkFire9";
            this.chkFire9.Size = new System.Drawing.Size(58, 16);
            this.chkFire9.TabIndex = 12;
            this.chkFire9.Text = "9 호차";
            this.chkFire9.UseVisualStyleBackColor = true;
            // 
            // chkFire8
            // 
            this.chkFire8.AutoSize = true;
            this.chkFire8.Location = new System.Drawing.Point(531, 20);
            this.chkFire8.Name = "chkFire8";
            this.chkFire8.Size = new System.Drawing.Size(58, 16);
            this.chkFire8.TabIndex = 11;
            this.chkFire8.Text = "8 호차";
            this.chkFire8.UseVisualStyleBackColor = true;
            // 
            // chkFire7
            // 
            this.chkFire7.AutoSize = true;
            this.chkFire7.Location = new System.Drawing.Point(467, 20);
            this.chkFire7.Name = "chkFire7";
            this.chkFire7.Size = new System.Drawing.Size(58, 16);
            this.chkFire7.TabIndex = 10;
            this.chkFire7.Text = "7 호차";
            this.chkFire7.UseVisualStyleBackColor = true;
            // 
            // chkFire6
            // 
            this.chkFire6.AutoSize = true;
            this.chkFire6.Location = new System.Drawing.Point(403, 20);
            this.chkFire6.Name = "chkFire6";
            this.chkFire6.Size = new System.Drawing.Size(58, 16);
            this.chkFire6.TabIndex = 9;
            this.chkFire6.Text = "6 호차";
            this.chkFire6.UseVisualStyleBackColor = true;
            // 
            // chkFire5
            // 
            this.chkFire5.AutoSize = true;
            this.chkFire5.Location = new System.Drawing.Point(339, 20);
            this.chkFire5.Name = "chkFire5";
            this.chkFire5.Size = new System.Drawing.Size(58, 16);
            this.chkFire5.TabIndex = 8;
            this.chkFire5.Text = "5 호차";
            this.chkFire5.UseVisualStyleBackColor = true;
            // 
            // chkFire4
            // 
            this.chkFire4.AutoSize = true;
            this.chkFire4.Location = new System.Drawing.Point(275, 20);
            this.chkFire4.Name = "chkFire4";
            this.chkFire4.Size = new System.Drawing.Size(58, 16);
            this.chkFire4.TabIndex = 7;
            this.chkFire4.Text = "4 호차";
            this.chkFire4.UseVisualStyleBackColor = true;
            // 
            // chkFire3
            // 
            this.chkFire3.AutoSize = true;
            this.chkFire3.Location = new System.Drawing.Point(211, 20);
            this.chkFire3.Name = "chkFire3";
            this.chkFire3.Size = new System.Drawing.Size(58, 16);
            this.chkFire3.TabIndex = 6;
            this.chkFire3.Text = "3 호차";
            this.chkFire3.UseVisualStyleBackColor = true;
            // 
            // chkFire2
            // 
            this.chkFire2.AutoSize = true;
            this.chkFire2.Location = new System.Drawing.Point(147, 20);
            this.chkFire2.Name = "chkFire2";
            this.chkFire2.Size = new System.Drawing.Size(58, 16);
            this.chkFire2.TabIndex = 5;
            this.chkFire2.Text = "2 호차";
            this.chkFire2.UseVisualStyleBackColor = true;
            // 
            // chkFire1
            // 
            this.chkFire1.AutoSize = true;
            this.chkFire1.Location = new System.Drawing.Point(83, 20);
            this.chkFire1.Name = "chkFire1";
            this.chkFire1.Size = new System.Drawing.Size(58, 16);
            this.chkFire1.TabIndex = 4;
            this.chkFire1.Text = "1 호차";
            this.chkFire1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPA9);
            this.groupBox2.Controls.Add(this.chkPA8);
            this.groupBox2.Controls.Add(this.chkPA7);
            this.groupBox2.Controls.Add(this.chkPA6);
            this.groupBox2.Controls.Add(this.chkPA5);
            this.groupBox2.Controls.Add(this.chkPA4);
            this.groupBox2.Controls.Add(this.chkPA3);
            this.groupBox2.Controls.Add(this.chkPA2);
            this.groupBox2.Controls.Add(this.chkPA1);
            this.groupBox2.Controls.Add(this.chkPA0);
            this.groupBox2.Location = new System.Drawing.Point(35, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 45);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PA0/PA1 감지";
            // 
            // chkPA9
            // 
            this.chkPA9.AutoSize = true;
            this.chkPA9.Location = new System.Drawing.Point(595, 20);
            this.chkPA9.Name = "chkPA9";
            this.chkPA9.Size = new System.Drawing.Size(58, 16);
            this.chkPA9.TabIndex = 12;
            this.chkPA9.Text = "9 호차";
            this.chkPA9.UseVisualStyleBackColor = true;
            // 
            // chkPA8
            // 
            this.chkPA8.AutoSize = true;
            this.chkPA8.Location = new System.Drawing.Point(531, 20);
            this.chkPA8.Name = "chkPA8";
            this.chkPA8.Size = new System.Drawing.Size(58, 16);
            this.chkPA8.TabIndex = 11;
            this.chkPA8.Text = "8 호차";
            this.chkPA8.UseVisualStyleBackColor = true;
            // 
            // chkPA7
            // 
            this.chkPA7.AutoSize = true;
            this.chkPA7.Location = new System.Drawing.Point(467, 20);
            this.chkPA7.Name = "chkPA7";
            this.chkPA7.Size = new System.Drawing.Size(58, 16);
            this.chkPA7.TabIndex = 10;
            this.chkPA7.Text = "7 호차";
            this.chkPA7.UseVisualStyleBackColor = true;
            // 
            // chkPA6
            // 
            this.chkPA6.AutoSize = true;
            this.chkPA6.Location = new System.Drawing.Point(403, 20);
            this.chkPA6.Name = "chkPA6";
            this.chkPA6.Size = new System.Drawing.Size(58, 16);
            this.chkPA6.TabIndex = 9;
            this.chkPA6.Text = "6 호차";
            this.chkPA6.UseVisualStyleBackColor = true;
            // 
            // chkPA5
            // 
            this.chkPA5.AutoSize = true;
            this.chkPA5.Location = new System.Drawing.Point(339, 20);
            this.chkPA5.Name = "chkPA5";
            this.chkPA5.Size = new System.Drawing.Size(58, 16);
            this.chkPA5.TabIndex = 8;
            this.chkPA5.Text = "5 호차";
            this.chkPA5.UseVisualStyleBackColor = true;
            // 
            // chkPA4
            // 
            this.chkPA4.AutoSize = true;
            this.chkPA4.Location = new System.Drawing.Point(275, 20);
            this.chkPA4.Name = "chkPA4";
            this.chkPA4.Size = new System.Drawing.Size(58, 16);
            this.chkPA4.TabIndex = 7;
            this.chkPA4.Text = "4 호차";
            this.chkPA4.UseVisualStyleBackColor = true;
            // 
            // chkPA3
            // 
            this.chkPA3.AutoSize = true;
            this.chkPA3.Location = new System.Drawing.Point(211, 20);
            this.chkPA3.Name = "chkPA3";
            this.chkPA3.Size = new System.Drawing.Size(58, 16);
            this.chkPA3.TabIndex = 6;
            this.chkPA3.Text = "3 호차";
            this.chkPA3.UseVisualStyleBackColor = true;
            // 
            // chkPA2
            // 
            this.chkPA2.AutoSize = true;
            this.chkPA2.Location = new System.Drawing.Point(147, 20);
            this.chkPA2.Name = "chkPA2";
            this.chkPA2.Size = new System.Drawing.Size(58, 16);
            this.chkPA2.TabIndex = 5;
            this.chkPA2.Text = "2 호차";
            this.chkPA2.UseVisualStyleBackColor = true;
            // 
            // chkPA1
            // 
            this.chkPA1.AutoSize = true;
            this.chkPA1.Location = new System.Drawing.Point(83, 20);
            this.chkPA1.Name = "chkPA1";
            this.chkPA1.Size = new System.Drawing.Size(58, 16);
            this.chkPA1.TabIndex = 4;
            this.chkPA1.Text = "1 호차";
            this.chkPA1.UseVisualStyleBackColor = true;
            // 
            // chkPA0
            // 
            this.chkPA0.AutoSize = true;
            this.chkPA0.Location = new System.Drawing.Point(19, 20);
            this.chkPA0.Name = "chkPA0";
            this.chkPA0.Size = new System.Drawing.Size(58, 16);
            this.chkPA0.TabIndex = 4;
            this.chkPA0.Text = "0 호차";
            this.chkPA0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.CheckBox chkFire0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFire1;
        private System.Windows.Forms.CheckBox chkFire8;
        private System.Windows.Forms.CheckBox chkFire7;
        private System.Windows.Forms.CheckBox chkFire6;
        private System.Windows.Forms.CheckBox chkFire5;
        private System.Windows.Forms.CheckBox chkFire4;
        private System.Windows.Forms.CheckBox chkFire3;
        private System.Windows.Forms.CheckBox chkFire2;
        private System.Windows.Forms.CheckBox chkFire9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPA9;
        private System.Windows.Forms.CheckBox chkPA8;
        private System.Windows.Forms.CheckBox chkPA7;
        private System.Windows.Forms.CheckBox chkPA6;
        private System.Windows.Forms.CheckBox chkPA5;
        private System.Windows.Forms.CheckBox chkPA4;
        private System.Windows.Forms.CheckBox chkPA3;
        private System.Windows.Forms.CheckBox chkPA2;
        private System.Windows.Forms.CheckBox chkPA1;
        private System.Windows.Forms.CheckBox chkPA0;
    }
}

