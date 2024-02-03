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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_Add_Input = new Button();
            btn_Add_Output = new Button();
            btn_Add_User = new Button();
            btn_Add_Project = new Button();
            btn_Add_Supplier = new Button();
            btn_Add_customer = new Button();
            btn_Add_Category = new Button();
            Quick_access = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(Quick_access);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 180);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Add_Input);
            groupBox1.Controls.Add(btn_Add_Output);
            groupBox1.Controls.Add(btn_Add_User);
            groupBox1.Controls.Add(btn_Add_Project);
            groupBox1.Controls.Add(btn_Add_Supplier);
            groupBox1.Controls.Add(btn_Add_customer);
            groupBox1.Controls.Add(btn_Add_Category);
            groupBox1.Location = new Point(343, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1175, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافة";
            // 
            // btn_Add_Input
            // 
            btn_Add_Input.Image = Properties.Resources.Input;
            btn_Add_Input.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_Input.Location = new Point(50, 37);
            btn_Add_Input.Margin = new Padding(5);
            btn_Add_Input.Name = "btn_Add_Input";
            btn_Add_Input.Size = new Size(140, 55);
            btn_Add_Input.TabIndex = 7;
            btn_Add_Input.Text = "قبض";
            btn_Add_Input.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Output
            // 
            btn_Add_Output.Image = Properties.Resources.Output_1;
            btn_Add_Output.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_Output.Location = new Point(200, 37);
            btn_Add_Output.Margin = new Padding(5);
            btn_Add_Output.Name = "btn_Add_Output";
            btn_Add_Output.Size = new Size(140, 55);
            btn_Add_Output.TabIndex = 6;
            btn_Add_Output.Text = "صرف";
            btn_Add_Output.UseVisualStyleBackColor = true;
            // 
            // btn_Add_User
            // 
            btn_Add_User.Image = Properties.Resources.Users;
            btn_Add_User.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_User.Location = new Point(350, 37);
            btn_Add_User.Margin = new Padding(5);
            btn_Add_User.Name = "btn_Add_User";
            btn_Add_User.Size = new Size(140, 55);
            btn_Add_User.TabIndex = 5;
            btn_Add_User.Text = "   مستخدم";
            btn_Add_User.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Project
            // 
            btn_Add_Project.Image = Properties.Resources.Requirements;
            btn_Add_Project.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_Project.Location = new Point(500, 39);
            btn_Add_Project.Margin = new Padding(5);
            btn_Add_Project.Name = "btn_Add_Project";
            btn_Add_Project.Size = new Size(140, 55);
            btn_Add_Project.TabIndex = 4;
            btn_Add_Project.Text = "مشروع";
            btn_Add_Project.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Supplier
            // 
            btn_Add_Supplier.Image = Properties.Resources.Supplier_1;
            btn_Add_Supplier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_Supplier.Location = new Point(650, 37);
            btn_Add_Supplier.Margin = new Padding(5);
            btn_Add_Supplier.Name = "btn_Add_Supplier";
            btn_Add_Supplier.Size = new Size(140, 55);
            btn_Add_Supplier.TabIndex = 3;
            btn_Add_Supplier.Text = "مورد";
            btn_Add_Supplier.UseVisualStyleBackColor = true;
            // 
            // btn_Add_customer
            // 
            btn_Add_customer.Image = Properties.Resources.Crowd_2;
            btn_Add_customer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_customer.Location = new Point(800, 37);
            btn_Add_customer.Margin = new Padding(5);
            btn_Add_customer.Name = "btn_Add_customer";
            btn_Add_customer.Size = new Size(140, 55);
            btn_Add_customer.TabIndex = 2;
            btn_Add_customer.Text = "عميل";
            btn_Add_customer.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Category
            // 
            btn_Add_Category.Image = Properties.Resources.Categorize_3;
            btn_Add_Category.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_Category.Location = new Point(950, 37);
            btn_Add_Category.Margin = new Padding(5);
            btn_Add_Category.Name = "btn_Add_Category";
            btn_Add_Category.Size = new Size(140, 55);
            btn_Add_Category.TabIndex = 1;
            btn_Add_Category.Text = "صنف";
            btn_Add_Category.UseVisualStyleBackColor = true;
            // 
            // Quick_access
            // 
            Quick_access.AutoSize = true;
            Quick_access.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Quick_access.Location = new Point(852, 1);
            Quick_access.Name = "Quick_access";
            Quick_access.Size = new Size(205, 56);
            Quick_access.TabIndex = 0;
            Quick_access.Text = "الوصول السريع";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Screenshot_2023_03_04_010144_transformed;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1270, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 56);
            label1.TabIndex = 7;
            label1.Text = "مرحبا بك ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 125);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // HomeUserControl1
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 7, 4, 7);
            Name = "HomeUserControl1";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1270, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Quick_access;
        private Button btn_Add_Category;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_Add_User;
        private Button btn_Add_Project;
        private Button btn_Add_Supplier;
        private Button btn_Add_customer;
        private Button btn_Add_Input;
        private Button btn_Add_Output;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
