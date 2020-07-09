namespace TextCounter
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.LblCountByteWoW = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblCountWoW = new System.Windows.Forms.Label();
            this.LblCountByteWW = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCountWW = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERFECT\r\nTEXT COUNTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "공백\r\n포함";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LblCountByteWoW);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LblCountWoW);
            this.panel1.Controls.Add(this.LblCountByteWW);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LblCountWW);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(186, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 88);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(352, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 43);
            this.label10.TabIndex = 10;
            this.label10.Text = "|";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCountByteWoW
            // 
            this.LblCountByteWoW.AutoSize = true;
            this.LblCountByteWoW.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblCountByteWoW.ForeColor = System.Drawing.Color.Black;
            this.LblCountByteWoW.Location = new System.Drawing.Point(642, 41);
            this.LblCountByteWoW.Name = "LblCountByteWoW";
            this.LblCountByteWoW.Size = new System.Drawing.Size(82, 21);
            this.LblCountByteWoW.TabIndex = 9;
            this.LblCountByteWoW.Text = "123456";
            this.LblCountByteWoW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(621, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "|";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(643, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "BYTE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCountWoW
            // 
            this.LblCountWoW.AutoSize = true;
            this.LblCountWoW.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblCountWoW.ForeColor = System.Drawing.Color.IndianRed;
            this.LblCountWoW.Location = new System.Drawing.Point(464, 19);
            this.LblCountWoW.Name = "LblCountWoW";
            this.LblCountWoW.Size = new System.Drawing.Size(151, 43);
            this.LblCountWoW.TabIndex = 6;
            this.LblCountWoW.Text = "123456";
            this.LblCountWoW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCountByteWW
            // 
            this.LblCountByteWW.AutoSize = true;
            this.LblCountByteWW.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblCountByteWW.ForeColor = System.Drawing.Color.Black;
            this.LblCountByteWW.Location = new System.Drawing.Point(243, 41);
            this.LblCountByteWW.Name = "LblCountByteWW";
            this.LblCountByteWW.Size = new System.Drawing.Size(82, 21);
            this.LblCountByteWW.TabIndex = 5;
            this.LblCountByteWW.Text = "123456";
            this.LblCountByteWW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(222, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "|";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(244, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "BYTE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCountWW
            // 
            this.LblCountWW.AutoSize = true;
            this.LblCountWW.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblCountWW.ForeColor = System.Drawing.Color.IndianRed;
            this.LblCountWW.Location = new System.Drawing.Point(65, 19);
            this.LblCountWW.Name = "LblCountWW";
            this.LblCountWW.Size = new System.Drawing.Size(151, 43);
            this.LblCountWW.TabIndex = 2;
            this.LblCountWW.Text = "123456";
            this.LblCountWW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(419, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "공백\r\n제외";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtInput
            // 
            this.TxtInput.BackColor = System.Drawing.Color.White;
            this.TxtInput.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtInput.Location = new System.Drawing.Point(186, 108);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtInput.Size = new System.Drawing.Size(745, 323);
            this.TxtInput.TabIndex = 2;
            this.TxtInput.WordWrap = false;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnClear.Location = new System.Drawing.Point(710, 437);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(108, 39);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "전체 지우기";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCopy.Location = new System.Drawing.Point(824, 437);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(108, 39);
            this.BtnCopy.TabIndex = 4;
            this.BtnCopy.Text = "전체 복사";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(29, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "HAENNIM PARK";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 490);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "글자 수 세기";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCountWW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblCountByteWoW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblCountWoW;
        private System.Windows.Forms.Label LblCountByteWW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Label label6;
    }
}

