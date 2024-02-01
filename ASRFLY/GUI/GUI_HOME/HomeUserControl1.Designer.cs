namespace ASRFLY.GUI.GUI_HOME
{
    partial class HomeUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Add_Input = new System.Windows.Forms.Button();
            this.btn_Add_Output = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.btn_Add_Project = new System.Windows.Forms.Button();
            this.btn_Add_Supplier = new System.Windows.Forms.Button();
            this.btn_Add_customer = new System.Windows.Forms.Button();
            this.btn_Add_Category = new System.Windows.Forms.Button();
            this.Quick_access = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Welcome = new System.Windows.Forms.Label();
            this.N_APP = new System.Windows.Forms.Label();
            this.Logo_Company = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Company)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Quick_access);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 180);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Add_Input);
            this.groupBox1.Controls.Add(this.btn_Add_Output);
            this.groupBox1.Controls.Add(this.btn_Add_User);
            this.groupBox1.Controls.Add(this.btn_Add_Project);
            this.groupBox1.Controls.Add(this.btn_Add_Supplier);
            this.groupBox1.Controls.Add(this.btn_Add_customer);
            this.groupBox1.Controls.Add(this.btn_Add_Category);
            this.groupBox1.Location = new System.Drawing.Point(142, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة";
            // 
            // btn_Add_Input
            // 
            this.btn_Add_Input.Image = global::ASRFLY.Properties.Resources.Input;
            this.btn_Add_Input.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Input.Location = new System.Drawing.Point(50, 37);
            this.btn_Add_Input.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_Input.Name = "btn_Add_Input";
            this.btn_Add_Input.Size = new System.Drawing.Size(140, 55);
            this.btn_Add_Input.TabIndex = 7;
            this.btn_Add_Input.Text = "قبض";
            this.btn_Add_Input.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Output
            // 
            this.btn_Add_Output.Image = global::ASRFLY.Properties.Resources.Output_1;
            this.btn_Add_Output.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Output.Location = new System.Drawing.Point(200, 37);
            this.btn_Add_Output.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_Output.Name = "btn_Add_Output";
            this.btn_Add_Output.Size = new System.Drawing.Size(140, 55);
            this.btn_Add_Output.TabIndex = 6;
            this.btn_Add_Output.Text = "صرف";
            this.btn_Add_Output.UseVisualStyleBackColor = true;
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Image = global::ASRFLY.Properties.Resources.Users;
            this.btn_Add_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_User.Location = new System.Drawing.Point(350, 37);
            this.btn_Add_User.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(140, 55);
            this.btn_Add_User.TabIndex = 5;
            this.btn_Add_User.Text = "   مستخدم";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Project
            // 
            this.btn_Add_Project.Image = global::ASRFLY.Properties.Resources.Requirements;
            this.btn_Add_Project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Project.Location = new System.Drawing.Point(500, 39);
            this.btn_Add_Project.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_Project.Name = "btn_Add_Project";
            this.btn_Add_Project.Size = new System.Drawing.Size(140, 55);
            this.btn_Add_Project.TabIndex = 4;
            this.btn_Add_Project.Text = "مشروع";
            this.btn_Add_Project.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Supplier
            // 
            this.btn_Add_Supplier.Image = global::ASRFLY.Properties.Resources.Supplier_1;
            this.btn_Add_Supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Supplier.Location = new System.Drawing.Point(650, 37);
            this.btn_Add_Supplier.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_Supplier.Name = "btn_Add_Supplier";
            this.btn_Add_Supplier.Size = new System.Drawing.Size(140, 55);
            this.btn_Add_Supplier.TabIndex = 3;
            this.btn_Add_Supplier.Text = "مورد";
            this.btn_Add_Supplier.UseVisualStyleBackColor = true;
            // 
            // btn_Add_customer
            // 
            this.btn_Add_customer.Image = global::ASRFLY.Properties.Resources.Crowd_2;
            this.btn_Add_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_customer.Location = new System.Drawing.Point(800, 37);
            this.btn_Add_customer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_customer.Name = "btn_Add_customer";
            this.btn_Add_customer.Size = new System.Drawing.Size(140, 55);
            this.btn_Add_customer.TabIndex = 2;
            this.btn_Add_customer.Text = "عميل";
            this.btn_Add_customer.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Category
            // 
            this.btn_Add_Category.Image = global::ASRFLY.Properties.Resources.Categorize_3;
            this.btn_Add_Category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Category.Location = new System.Drawing.Point(950, 37);
            this.btn_Add_Category.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add_Category.Name = "btn_Add_Category";
            this.btn_Add_Category.Size = new System.Drawing.Size(140, 55);
            this.btn_Add_Category.TabIndex = 1;
            this.btn_Add_Category.Text = "صنف";
            this.btn_Add_Category.UseVisualStyleBackColor = true;
            // 
            // Quick_access
            // 
            this.Quick_access.AutoSize = true;
            this.Quick_access.Font = new System.Drawing.Font("Cairo", 18F);
            this.Quick_access.Location = new System.Drawing.Point(653, 7);
            this.Quick_access.Name = "Quick_access";
            this.Quick_access.Size = new System.Drawing.Size(205, 56);
            this.Quick_access.TabIndex = 0;
            this.Quick_access.Text = "الوصول السريع";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Cairo", 18F);
            this.Welcome.Location = new System.Drawing.Point(1193, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(134, 56);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "مرحبا بك ";
            // 
            // N_APP
            // 
            this.N_APP.AutoSize = true;
            this.N_APP.Font = new System.Drawing.Font("Cairo", 18F);
            this.N_APP.Location = new System.Drawing.Point(0, 3);
            this.N_APP.Name = "N_APP";
            this.N_APP.Size = new System.Drawing.Size(119, 56);
            this.N_APP.TabIndex = 5;
            this.N_APP.Text = "ASRFLY";
            // 
            // Logo_Company
            // 
            this.Logo_Company.Image = global::ASRFLY.Properties.Resources.Screenshot_2023_03_04_010144_transformed;
            this.Logo_Company.Location = new System.Drawing.Point(58, 62);
            this.Logo_Company.Name = "Logo_Company";
            this.Logo_Company.Size = new System.Drawing.Size(1384, 435);
            this.Logo_Company.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_Company.TabIndex = 6;
            this.Logo_Company.TabStop = false;
            // 
            // HomeUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.Logo_Company);
            this.Controls.Add(this.N_APP);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "HomeUserControl1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1270, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Quick_access;
        private System.Windows.Forms.Button btn_Add_Category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.Button btn_Add_Project;
        private System.Windows.Forms.Button btn_Add_Supplier;
        private System.Windows.Forms.Button btn_Add_customer;
        private System.Windows.Forms.Button btn_Add_Input;
        private System.Windows.Forms.Button btn_Add_Output;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label N_APP;
        private System.Windows.Forms.PictureBox Logo_Company;
    }
}
