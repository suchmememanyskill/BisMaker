namespace BisMaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_openboot0 = new System.Windows.Forms.Button();
            this.lbl_boot0_path = new System.Windows.Forms.Label();
            this.lbl_boot0_size = new System.Windows.Forms.Label();
            this.lbl_boot1_size = new System.Windows.Forms.Label();
            this.lbl_boot1_path = new System.Windows.Forms.Label();
            this.btn_openboot1 = new System.Windows.Forms.Button();
            this.lbl_bcpkg2_1_size = new System.Windows.Forms.Label();
            this.lbl_bcpkg2_1_path = new System.Windows.Forms.Label();
            this.btn_openbcpkg2_1 = new System.Windows.Forms.Button();
            this.lbl_bcpkg2_3_size = new System.Windows.Forms.Label();
            this.lbl_bcpkg2_3_path = new System.Windows.Forms.Label();
            this.btn_openbcpkg2_3 = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_generate_bis = new System.Windows.Forms.Button();
            this.pb_creation = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_embeddedversion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bis file creator for TegraExplorer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "v1.0.0";
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "BOOT0";
            // 
            // btn_openboot0
            // 
            this.btn_openboot0.Location = new System.Drawing.Point(12, 69);
            this.btn_openboot0.Name = "btn_openboot0";
            this.btn_openboot0.Size = new System.Drawing.Size(105, 23);
            this.btn_openboot0.TabIndex = 2;
            this.btn_openboot0.Text = "Open BOOT0";
            this.btn_openboot0.UseVisualStyleBackColor = true;
            this.btn_openboot0.Click += new System.EventHandler(this.btn_openboot0_Click);
            // 
            // lbl_boot0_path
            // 
            this.lbl_boot0_path.AutoSize = true;
            this.lbl_boot0_path.Location = new System.Drawing.Point(12, 95);
            this.lbl_boot0_path.Name = "lbl_boot0_path";
            this.lbl_boot0_path.Size = new System.Drawing.Size(13, 13);
            this.lbl_boot0_path.TabIndex = 3;
            this.lbl_boot0_path.Text = "?";
            // 
            // lbl_boot0_size
            // 
            this.lbl_boot0_size.AutoSize = true;
            this.lbl_boot0_size.Location = new System.Drawing.Point(123, 74);
            this.lbl_boot0_size.Name = "lbl_boot0_size";
            this.lbl_boot0_size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_boot0_size.Size = new System.Drawing.Size(39, 13);
            this.lbl_boot0_size.TabIndex = 4;
            this.lbl_boot0_size.Text = "Size: ?";
            // 
            // lbl_boot1_size
            // 
            this.lbl_boot1_size.AutoSize = true;
            this.lbl_boot1_size.Location = new System.Drawing.Point(123, 139);
            this.lbl_boot1_size.Name = "lbl_boot1_size";
            this.lbl_boot1_size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_boot1_size.Size = new System.Drawing.Size(39, 13);
            this.lbl_boot1_size.TabIndex = 7;
            this.lbl_boot1_size.Text = "Size: ?";
            // 
            // lbl_boot1_path
            // 
            this.lbl_boot1_path.AutoSize = true;
            this.lbl_boot1_path.Location = new System.Drawing.Point(12, 160);
            this.lbl_boot1_path.Name = "lbl_boot1_path";
            this.lbl_boot1_path.Size = new System.Drawing.Size(13, 13);
            this.lbl_boot1_path.TabIndex = 6;
            this.lbl_boot1_path.Text = "?";
            // 
            // btn_openboot1
            // 
            this.btn_openboot1.Location = new System.Drawing.Point(12, 134);
            this.btn_openboot1.Name = "btn_openboot1";
            this.btn_openboot1.Size = new System.Drawing.Size(105, 23);
            this.btn_openboot1.TabIndex = 5;
            this.btn_openboot1.Text = "Open BOOT1";
            this.btn_openboot1.UseVisualStyleBackColor = true;
            this.btn_openboot1.Click += new System.EventHandler(this.btn_openboot1_Click);
            // 
            // lbl_bcpkg2_1_size
            // 
            this.lbl_bcpkg2_1_size.AutoSize = true;
            this.lbl_bcpkg2_1_size.Location = new System.Drawing.Point(123, 207);
            this.lbl_bcpkg2_1_size.Name = "lbl_bcpkg2_1_size";
            this.lbl_bcpkg2_1_size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_bcpkg2_1_size.Size = new System.Drawing.Size(39, 13);
            this.lbl_bcpkg2_1_size.TabIndex = 10;
            this.lbl_bcpkg2_1_size.Text = "Size: ?";
            // 
            // lbl_bcpkg2_1_path
            // 
            this.lbl_bcpkg2_1_path.AutoSize = true;
            this.lbl_bcpkg2_1_path.Location = new System.Drawing.Point(12, 228);
            this.lbl_bcpkg2_1_path.Name = "lbl_bcpkg2_1_path";
            this.lbl_bcpkg2_1_path.Size = new System.Drawing.Size(13, 13);
            this.lbl_bcpkg2_1_path.TabIndex = 9;
            this.lbl_bcpkg2_1_path.Text = "?";
            // 
            // btn_openbcpkg2_1
            // 
            this.btn_openbcpkg2_1.Location = new System.Drawing.Point(12, 202);
            this.btn_openbcpkg2_1.Name = "btn_openbcpkg2_1";
            this.btn_openbcpkg2_1.Size = new System.Drawing.Size(105, 23);
            this.btn_openbcpkg2_1.TabIndex = 8;
            this.btn_openbcpkg2_1.Text = "Open BCPKG2_1";
            this.btn_openbcpkg2_1.UseVisualStyleBackColor = true;
            this.btn_openbcpkg2_1.Click += new System.EventHandler(this.btn_openbcpkg2_1_Click);
            // 
            // lbl_bcpkg2_3_size
            // 
            this.lbl_bcpkg2_3_size.AutoSize = true;
            this.lbl_bcpkg2_3_size.Location = new System.Drawing.Point(123, 275);
            this.lbl_bcpkg2_3_size.Name = "lbl_bcpkg2_3_size";
            this.lbl_bcpkg2_3_size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_bcpkg2_3_size.Size = new System.Drawing.Size(39, 13);
            this.lbl_bcpkg2_3_size.TabIndex = 13;
            this.lbl_bcpkg2_3_size.Text = "Size: ?";
            // 
            // lbl_bcpkg2_3_path
            // 
            this.lbl_bcpkg2_3_path.AutoSize = true;
            this.lbl_bcpkg2_3_path.Location = new System.Drawing.Point(12, 296);
            this.lbl_bcpkg2_3_path.Name = "lbl_bcpkg2_3_path";
            this.lbl_bcpkg2_3_path.Size = new System.Drawing.Size(13, 13);
            this.lbl_bcpkg2_3_path.TabIndex = 12;
            this.lbl_bcpkg2_3_path.Text = "?";
            // 
            // btn_openbcpkg2_3
            // 
            this.btn_openbcpkg2_3.Location = new System.Drawing.Point(12, 270);
            this.btn_openbcpkg2_3.Name = "btn_openbcpkg2_3";
            this.btn_openbcpkg2_3.Size = new System.Drawing.Size(105, 23);
            this.btn_openbcpkg2_3.TabIndex = 11;
            this.btn_openbcpkg2_3.Text = "Open BCPKG2_3";
            this.btn_openbcpkg2_3.UseVisualStyleBackColor = true;
            this.btn_openbcpkg2_3.Click += new System.EventHandler(this.btn_openbcpkg2_3_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 383);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(53, 13);
            this.lbl_status.TabIndex = 14;
            this.lbl_status.Text = "Unknown";
            // 
            // btn_generate_bis
            // 
            this.btn_generate_bis.Location = new System.Drawing.Point(12, 399);
            this.btn_generate_bis.Name = "btn_generate_bis";
            this.btn_generate_bis.Size = new System.Drawing.Size(75, 61);
            this.btn_generate_bis.TabIndex = 15;
            this.btn_generate_bis.Text = "Generate";
            this.btn_generate_bis.UseVisualStyleBackColor = true;
            this.btn_generate_bis.Click += new System.EventHandler(this.btn_generate_bis_Click);
            // 
            // pb_creation
            // 
            this.pb_creation.Location = new System.Drawing.Point(93, 399);
            this.pb_creation.Name = "pb_creation";
            this.pb_creation.Size = new System.Drawing.Size(556, 61);
            this.pb_creation.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "EmbeddedVersion:";
            // 
            // tb_embeddedversion
            // 
            this.tb_embeddedversion.Location = new System.Drawing.Point(12, 346);
            this.tb_embeddedversion.MaxLength = 15;
            this.tb_embeddedversion.Name = "tb_embeddedversion";
            this.tb_embeddedversion.Size = new System.Drawing.Size(637, 20);
            this.tb_embeddedversion.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 473);
            this.Controls.Add(this.tb_embeddedversion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_creation);
            this.Controls.Add(this.btn_generate_bis);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_bcpkg2_3_size);
            this.Controls.Add(this.lbl_bcpkg2_3_path);
            this.Controls.Add(this.btn_openbcpkg2_3);
            this.Controls.Add(this.lbl_bcpkg2_1_size);
            this.Controls.Add(this.lbl_bcpkg2_1_path);
            this.Controls.Add(this.btn_openbcpkg2_1);
            this.Controls.Add(this.lbl_boot1_size);
            this.Controls.Add(this.lbl_boot1_path);
            this.Controls.Add(this.btn_openboot1);
            this.Controls.Add(this.lbl_boot0_size);
            this.Controls.Add(this.lbl_boot0_path);
            this.Controls.Add(this.btn_openboot0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BisMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button btn_openboot0;
        private System.Windows.Forms.Label lbl_boot0_path;
        private System.Windows.Forms.Label lbl_boot0_size;
        private System.Windows.Forms.Label lbl_boot1_size;
        private System.Windows.Forms.Label lbl_boot1_path;
        private System.Windows.Forms.Button btn_openboot1;
        private System.Windows.Forms.Label lbl_bcpkg2_1_size;
        private System.Windows.Forms.Label lbl_bcpkg2_1_path;
        private System.Windows.Forms.Button btn_openbcpkg2_1;
        private System.Windows.Forms.Label lbl_bcpkg2_3_size;
        private System.Windows.Forms.Label lbl_bcpkg2_3_path;
        private System.Windows.Forms.Button btn_openbcpkg2_3;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_generate_bis;
        private System.Windows.Forms.ProgressBar pb_creation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_embeddedversion;
    }
}

