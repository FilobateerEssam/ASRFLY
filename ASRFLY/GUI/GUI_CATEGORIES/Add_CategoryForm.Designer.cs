namespace ASRFLY.GUI.GUI_CATEGORIES
{
    partial class Add_CategoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bx_Cat_details = new System.Windows.Forms.RichTextBox();
            this.cmb_bx_Cat_Type = new System.Windows.Forms.ComboBox();
            this.txt_bx_Cat_Balance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bx_Cat_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Save_Close);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 71);
            this.panel1.TabIndex = 0;
            // 
            // btn_Save_Close
            // 
            this.btn_Save_Close.AllowDrop = true;
            this.btn_Save_Close.Image = global::ASRFLY.Properties.Resources.Save;
            this.btn_Save_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save_Close.Location = new System.Drawing.Point(43, 5);
            this.btn_Save_Close.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Save_Close.Name = "btn_Save_Close";
            this.btn_Save_Close.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Save_Close.Size = new System.Drawing.Size(271, 55);
            this.btn_Save_Close.TabIndex = 16;
            this.btn_Save_Close.Text = "حفظ و غلق";
            this.btn_Save_Close.UseVisualStyleBackColor = true;
            this.btn_Save_Close.Click += new System.EventHandler(this.btn_Save_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AllowDrop = true;
            this.btn_Save.Image = global::ASRFLY.Properties.Resources.Save_1;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(378, 5);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Save.Size = new System.Drawing.Size(271, 55);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "حفظ فقط";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_bx_Cat_details);
            this.groupBox1.Controls.Add(this.cmb_bx_Cat_Type);
            this.groupBox1.Controls.Add(this.txt_bx_Cat_Balance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_bx_Cat_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 535);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الصنف";
            // 
            // txt_bx_Cat_details
            // 
            this.txt_bx_Cat_details.Location = new System.Drawing.Point(7, 265);
            this.txt_bx_Cat_details.Name = "txt_bx_Cat_details";
            this.txt_bx_Cat_details.Size = new System.Drawing.Size(507, 151);
            this.txt_bx_Cat_details.TabIndex = 9;
            this.txt_bx_Cat_details.Text = "";
            // 
            // cmb_bx_Cat_Type
            // 
            this.cmb_bx_Cat_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bx_Cat_Type.FormattingEnabled = true;
            this.cmb_bx_Cat_Type.Items.AddRange(new object[] {
            "صرف",
            "قبض"});
            this.cmb_bx_Cat_Type.Location = new System.Drawing.Point(6, 166);
            this.cmb_bx_Cat_Type.Name = "cmb_bx_Cat_Type";
            this.cmb_bx_Cat_Type.Size = new System.Drawing.Size(508, 45);
            this.cmb_bx_Cat_Type.TabIndex = 8;
            // 
            // txt_bx_Cat_Balance
            // 
            this.txt_bx_Cat_Balance.Enabled = false;
            this.txt_bx_Cat_Balance.Location = new System.Drawing.Point(6, 462);
            this.txt_bx_Cat_Balance.Name = "txt_bx_Cat_Balance";
            this.txt_bx_Cat_Balance.Size = new System.Drawing.Size(508, 45);
            this.txt_bx_Cat_Balance.TabIndex = 7;
            this.txt_bx_Cat_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "الرصيد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "التفاصيل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الصنف";
            // 
            // txt_bx_Cat_Name
            // 
            this.txt_bx_Cat_Name.Location = new System.Drawing.Point(6, 79);
            this.txt_bx_Cat_Name.Name = "txt_bx_Cat_Name";
            this.txt_bx_Cat_Name.Size = new System.Drawing.Size(508, 45);
            this.txt_bx_Cat_Name.TabIndex = 1;
            this.txt_bx_Cat_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // Add_CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.Name = "Add_CategoryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة - تعديل صنف";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_bx_Cat_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_bx_Cat_Type;
        private System.Windows.Forms.TextBox txt_bx_Cat_Balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_bx_Cat_details;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Save_Close;
    }
}