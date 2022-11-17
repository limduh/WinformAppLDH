namespace MainForm
{
    partial class M01_LogIn
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
            this.btnwasswordch = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnwasswordch
            // 
            this.btnwasswordch.Location = new System.Drawing.Point(322, 107);
            this.btnwasswordch.Name = "btnwasswordch";
            this.btnwasswordch.Size = new System.Drawing.Size(75, 66);
            this.btnwasswordch.TabIndex = 23;
            this.btnwasswordch.Text = "비밀번호 변경";
            this.btnwasswordch.UseVisualStyleBackColor = true;
            this.btnwasswordch.Click += new System.EventHandler(this.btnwasswordch_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(241, 107);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 66);
            this.btnlogin.TabIndex = 22;
            this.btnlogin.Text = "로그인";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(103, 71);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(292, 21);
            this.txtPw.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(103, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(292, 21);
            this.txtID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "P/W";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "사용자 아이디";
            // 
            // M01_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 206);
            this.Controls.Add(this.btnwasswordch);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "M01_LogIn";
            this.Text = "M01_LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwasswordch;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

