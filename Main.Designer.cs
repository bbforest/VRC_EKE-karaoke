﻿
namespace EKE_karaoke
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TextBox_VRCUrl = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_Songname = new System.Windows.Forms.RichTextBox();
            this.TextBox_Request = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TJTextBox = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextBox_VRCUrl
            // 
            this.TextBox_VRCUrl.Location = new System.Drawing.Point(12, 276);
            this.TextBox_VRCUrl.Name = "TextBox_VRCUrl";
            this.TextBox_VRCUrl.Size = new System.Drawing.Size(304, 369);
            this.TextBox_VRCUrl.TabIndex = 0;
            this.TextBox_VRCUrl.Text = "//퀘스트패치 https://t-ne.x0.to/?url=https://\nVRCUrl n0 = new VRCUrl(\"https://bbforest" +
    ".net/karaoke.mp4\");\nVRCUrl q0 = new VRCUrl(\"https://bbforest.net/karaoke.mp4\");\n" +
    "문자열삽입위치";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "엑셀 -> 코드";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_Songname
            // 
            this.TextBox_Songname.Location = new System.Drawing.Point(322, 276);
            this.TextBox_Songname.Name = "TextBox_Songname";
            this.TextBox_Songname.Size = new System.Drawing.Size(298, 369);
            this.TextBox_Songname.TabIndex = 0;
            this.TextBox_Songname.Text = resources.GetString("TextBox_Songname.Text");
            // 
            // TextBox_Request
            // 
            this.TextBox_Request.Location = new System.Drawing.Point(626, 276);
            this.TextBox_Request.Name = "TextBox_Request";
            this.TextBox_Request.Size = new System.Drawing.Size(452, 369);
            this.TextBox_Request.TabIndex = 0;
            this.TextBox_Request.Text = resources.GetString("TextBox_Request.Text");
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 44);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(560, 226);
            this.Result.TabIndex = 0;
            this.Result.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "TJ노래방 인기차트";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TJTextBox
            // 
            this.TJTextBox.Location = new System.Drawing.Point(578, 44);
            this.TJTextBox.Name = "TJTextBox";
            this.TJTextBox.Size = new System.Drawing.Size(500, 226);
            this.TJTextBox.TabIndex = 0;
            this.TJTextBox.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(405, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 657);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_Request);
            this.Controls.Add(this.TJTextBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.TextBox_Songname);
            this.Controls.Add(this.TextBox_VRCUrl);
            this.Name = "Main";
            this.Text = "에케 노래방 노래 등록 시스템";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox_VRCUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TextBox_Songname;
        private System.Windows.Forms.RichTextBox TextBox_Request;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox TJTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

