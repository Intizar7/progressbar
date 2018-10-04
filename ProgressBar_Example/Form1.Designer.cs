namespace ProgressBar_Example
{
    partial class form
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
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.btn_for_pb1 = new System.Windows.Forms.Button();
            this.btn_for_pb2 = new System.Windows.Forms.Button();
            this.btn_for_pb3 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toggleBtn1 = new System.Windows.Forms.Button();
            this.toggleBtn2 = new System.Windows.Forms.Button();
            this.toggleBtn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(72, 46);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(332, 39);
            this.pb1.Step = 2;
            this.pb1.TabIndex = 0;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(72, 108);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(332, 39);
            this.pb2.TabIndex = 1;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(72, 161);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(332, 39);
            this.pb3.TabIndex = 2;
            // 
            // btn_for_pb1
            // 
            this.btn_for_pb1.Location = new System.Drawing.Point(410, 46);
            this.btn_for_pb1.Name = "btn_for_pb1";
            this.btn_for_pb1.Size = new System.Drawing.Size(66, 39);
            this.btn_for_pb1.TabIndex = 3;
            this.btn_for_pb1.Text = "Start The Bar  ";
            this.btn_for_pb1.UseVisualStyleBackColor = true;
            this.btn_for_pb1.Click += new System.EventHandler(this.btn_for_pb1_Click);
            // 
            // btn_for_pb2
            // 
            this.btn_for_pb2.Location = new System.Drawing.Point(410, 108);
            this.btn_for_pb2.Name = "btn_for_pb2";
            this.btn_for_pb2.Size = new System.Drawing.Size(66, 39);
            this.btn_for_pb2.TabIndex = 4;
            this.btn_for_pb2.Text = "Start The Bar  ";
            this.btn_for_pb2.UseVisualStyleBackColor = true;
            this.btn_for_pb2.Click += new System.EventHandler(this.btn_for_pb2_Click);
            // 
            // btn_for_pb3
            // 
            this.btn_for_pb3.Location = new System.Drawing.Point(410, 161);
            this.btn_for_pb3.Name = "btn_for_pb3";
            this.btn_for_pb3.Size = new System.Drawing.Size(66, 39);
            this.btn_for_pb3.TabIndex = 5;
            this.btn_for_pb3.Text = "Start The Bar  ";
            this.btn_for_pb3.UseVisualStyleBackColor = true;
            this.btn_for_pb3.Click += new System.EventHandler(this.btn_for_pb3_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 20);
            this.textBox1.TabIndex = 6;
            // 
            // toggleBtn1
            // 
            this.toggleBtn1.Location = new System.Drawing.Point(482, 46);
            this.toggleBtn1.Name = "toggleBtn1";
            this.toggleBtn1.Size = new System.Drawing.Size(66, 39);
            this.toggleBtn1.TabIndex = 7;
            this.toggleBtn1.Text = "Toggle The Bar";
            this.toggleBtn1.UseVisualStyleBackColor = true;
            this.toggleBtn1.Click += new System.EventHandler(this.toggleBtn1_Click);
            // 
            // toggleBtn2
            // 
            this.toggleBtn2.Location = new System.Drawing.Point(482, 108);
            this.toggleBtn2.Name = "toggleBtn2";
            this.toggleBtn2.Size = new System.Drawing.Size(66, 39);
            this.toggleBtn2.TabIndex = 8;
            this.toggleBtn2.Text = "Toggle The Bar";
            this.toggleBtn2.UseVisualStyleBackColor = true;
            // 
            // toggleBtn3
            // 
            this.toggleBtn3.Location = new System.Drawing.Point(482, 161);
            this.toggleBtn3.Name = "toggleBtn3";
            this.toggleBtn3.Size = new System.Drawing.Size(66, 39);
            this.toggleBtn3.TabIndex = 9;
            this.toggleBtn3.Text = "Toggle The Bar";
            this.toggleBtn3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Message: ";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleBtn3);
            this.Controls.Add(this.toggleBtn2);
            this.Controls.Add(this.toggleBtn1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_for_pb3);
            this.Controls.Add(this.btn_for_pb2);
            this.Controls.Add(this.btn_for_pb1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.ProgressBar pb3;
        private System.Windows.Forms.Button btn_for_pb1;
        private System.Windows.Forms.Button btn_for_pb2;
        private System.Windows.Forms.Button btn_for_pb3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button toggleBtn1;
        private System.Windows.Forms.Button toggleBtn2;
        private System.Windows.Forms.Button toggleBtn3;
        private System.Windows.Forms.Label label1;
    }
}

