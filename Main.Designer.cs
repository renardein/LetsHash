namespace LetsHash
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gr_actions = new System.Windows.Forms.GroupBox();
            this.rb_cod = new System.Windows.Forms.RadioButton();
            this.rb_enc = new System.Windows.Forms.RadioButton();
            this.gr_types = new System.Windows.Forms.GroupBox();
            this.rb_sha512 = new System.Windows.Forms.RadioButton();
            this.rb_sha384 = new System.Windows.Forms.RadioButton();
            this.rb_sha256 = new System.Windows.Forms.RadioButton();
            this.rb_sha1 = new System.Windows.Forms.RadioButton();
            this.rb_base64 = new System.Windows.Forms.RadioButton();
            this.rb_md5 = new System.Windows.Forms.RadioButton();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gr_actions.SuspendLayout();
            this.gr_types.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(13, 45);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.Size = new System.Drawing.Size(293, 91);
            this.tb_output.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gr_actions
            // 
            this.gr_actions.Controls.Add(this.rb_cod);
            this.gr_actions.Controls.Add(this.rb_enc);
            this.gr_actions.Location = new System.Drawing.Point(178, 142);
            this.gr_actions.Name = "gr_actions";
            this.gr_actions.Size = new System.Drawing.Size(128, 91);
            this.gr_actions.TabIndex = 15;
            this.gr_actions.TabStop = false;
            this.gr_actions.Text = "Action:";
            // 
            // rb_cod
            // 
            this.rb_cod.AutoSize = true;
            this.rb_cod.Location = new System.Drawing.Point(6, 19);
            this.rb_cod.Name = "rb_cod";
            this.rb_cod.Size = new System.Drawing.Size(58, 17);
            this.rb_cod.TabIndex = 0;
            this.rb_cod.TabStop = true;
            this.rb_cod.Text = "Coding";
            this.rb_cod.UseVisualStyleBackColor = true;
            // 
            // rb_enc
            // 
            this.rb_enc.AutoSize = true;
            this.rb_enc.Location = new System.Drawing.Point(6, 42);
            this.rb_enc.Name = "rb_enc";
            this.rb_enc.Size = new System.Drawing.Size(70, 17);
            this.rb_enc.TabIndex = 1;
            this.rb_enc.TabStop = true;
            this.rb_enc.Tag = "Encoding";
            this.rb_enc.Text = "Encoding";
            this.rb_enc.UseVisualStyleBackColor = true;
            // 
            // gr_types
            // 
            this.gr_types.Controls.Add(this.rb_sha512);
            this.gr_types.Controls.Add(this.rb_sha384);
            this.gr_types.Controls.Add(this.rb_sha256);
            this.gr_types.Controls.Add(this.rb_sha1);
            this.gr_types.Controls.Add(this.rb_base64);
            this.gr_types.Controls.Add(this.rb_md5);
            this.gr_types.Location = new System.Drawing.Point(13, 142);
            this.gr_types.Name = "gr_types";
            this.gr_types.Size = new System.Drawing.Size(159, 91);
            this.gr_types.TabIndex = 14;
            this.gr_types.TabStop = false;
            this.gr_types.Text = "Hash type:";
            // 
            // rb_sha512
            // 
            this.rb_sha512.AutoSize = true;
            this.rb_sha512.Location = new System.Drawing.Point(88, 42);
            this.rb_sha512.Name = "rb_sha512";
            this.rb_sha512.Size = new System.Drawing.Size(65, 17);
            this.rb_sha512.TabIndex = 5;
            this.rb_sha512.TabStop = true;
            this.rb_sha512.Tag = "Encoding";
            this.rb_sha512.Text = "SHA512";
            this.rb_sha512.UseVisualStyleBackColor = true;
            // 
            // rb_sha384
            // 
            this.rb_sha384.AutoSize = true;
            this.rb_sha384.Location = new System.Drawing.Point(88, 65);
            this.rb_sha384.Name = "rb_sha384";
            this.rb_sha384.Size = new System.Drawing.Size(65, 17);
            this.rb_sha384.TabIndex = 4;
            this.rb_sha384.TabStop = true;
            this.rb_sha384.Tag = "Encoding";
            this.rb_sha384.Text = "SHA384";
            this.rb_sha384.UseVisualStyleBackColor = true;
            // 
            // rb_sha256
            // 
            this.rb_sha256.AutoSize = true;
            this.rb_sha256.Location = new System.Drawing.Point(6, 65);
            this.rb_sha256.Name = "rb_sha256";
            this.rb_sha256.Size = new System.Drawing.Size(65, 17);
            this.rb_sha256.TabIndex = 3;
            this.rb_sha256.TabStop = true;
            this.rb_sha256.Tag = "Encoding";
            this.rb_sha256.Text = "SHA256";
            this.rb_sha256.UseVisualStyleBackColor = true;
            // 
            // rb_sha1
            // 
            this.rb_sha1.AutoSize = true;
            this.rb_sha1.Location = new System.Drawing.Point(8, 42);
            this.rb_sha1.Name = "rb_sha1";
            this.rb_sha1.Size = new System.Drawing.Size(53, 17);
            this.rb_sha1.TabIndex = 2;
            this.rb_sha1.TabStop = true;
            this.rb_sha1.Tag = "Encoding";
            this.rb_sha1.Text = "SHA1";
            this.rb_sha1.UseVisualStyleBackColor = true;
            // 
            // rb_base64
            // 
            this.rb_base64.AutoSize = true;
            this.rb_base64.Location = new System.Drawing.Point(8, 19);
            this.rb_base64.Name = "rb_base64";
            this.rb_base64.Size = new System.Drawing.Size(61, 17);
            this.rb_base64.TabIndex = 0;
            this.rb_base64.TabStop = true;
            this.rb_base64.Text = "Base64";
            this.rb_base64.UseVisualStyleBackColor = true;
            this.rb_base64.CheckedChanged += new System.EventHandler(this.rb_base64_CheckedChanged);
            // 
            // rb_md5
            // 
            this.rb_md5.AutoSize = true;
            this.rb_md5.Location = new System.Drawing.Point(88, 19);
            this.rb_md5.Name = "rb_md5";
            this.rb_md5.Size = new System.Drawing.Size(48, 17);
            this.rb_md5.TabIndex = 1;
            this.rb_md5.TabStop = true;
            this.rb_md5.Tag = "Encoding";
            this.rb_md5.Text = "MD5";
            this.rb_md5.UseVisualStyleBackColor = true;
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_input.Location = new System.Drawing.Point(13, 12);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(293, 30);
            this.tb_input.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(261, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 41);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 286);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gr_actions);
            this.Controls.Add(this.gr_types);
            this.Controls.Add(this.tb_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Let\'s Hash";
            this.gr_actions.ResumeLayout(false);
            this.gr_actions.PerformLayout();
            this.gr_types.ResumeLayout(false);
            this.gr_types.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gr_actions;
        private System.Windows.Forms.RadioButton rb_cod;
        private System.Windows.Forms.RadioButton rb_enc;
        private System.Windows.Forms.GroupBox gr_types;
        private System.Windows.Forms.RadioButton rb_sha512;
        private System.Windows.Forms.RadioButton rb_sha384;
        private System.Windows.Forms.RadioButton rb_sha256;
        private System.Windows.Forms.RadioButton rb_sha1;
        private System.Windows.Forms.RadioButton rb_base64;
        private System.Windows.Forms.RadioButton rb_md5;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button button2;
    }
}

