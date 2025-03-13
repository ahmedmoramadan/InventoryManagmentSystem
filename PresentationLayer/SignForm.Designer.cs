namespace PresentationLayer
{
    partial class SignForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            lbl_signin = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txt_signinPass = new TextBox();
            lbl_signInPassError = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            lbl_signInUserError = new Label();
            txt_signinName = new TextBox();
            pictureBox4 = new PictureBox();
            lbl_signInerrorMsg = new Label();
            btn_signInReset = new CustomControls.RoundedButton();
            btn_login = new CustomControls.RoundedButton();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 76, 245);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_signin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lbl_signInerrorMsg);
            panel1.Controls.Add(btn_signInReset);
            panel1.Controls.Add(btn_login);
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(419, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 490);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 389);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Forget Your Password?";
            // 
            // lbl_signin
            // 
            lbl_signin.AutoSize = true;
            lbl_signin.Cursor = Cursors.Hand;
            lbl_signin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signin.Location = new Point(159, 72);
            lbl_signin.Name = "lbl_signin";
            lbl_signin.Size = new Size(99, 31);
            lbl_signin.TabIndex = 0;
            lbl_signin.Text = "SIGN IN";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = InventoryManagmentSystem.PL.Properties.Resources.cross;
            pictureBox2.Location = new Point(384, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txt_signinPass);
            panel2.Controls.Add(lbl_signInPassError);
            panel2.Controls.Add(pictureBox3);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 45);
            panel2.TabIndex = 1;
            // 
            // txt_signinPass
            // 
            txt_signinPass.BackColor = Color.White;
            txt_signinPass.BorderStyle = BorderStyle.None;
            txt_signinPass.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signinPass.ForeColor = Color.FromArgb(39, 59, 122);
            txt_signinPass.Location = new Point(62, 12);
            txt_signinPass.Name = "txt_signinPass";
            txt_signinPass.PlaceholderText = "Enter your password\n";
            txt_signinPass.Size = new Size(316, 21);
            txt_signinPass.TabIndex = 1;
            txt_signinPass.UseSystemPasswordChar = true;
            txt_signinPass.Click += txt_signinPass_Click;
            txt_signinPass.TextChanged += txt_signinPass_TextChanged;
            // 
            // lbl_signInPassError
            // 
            lbl_signInPassError.AutoSize = true;
            lbl_signInPassError.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signInPassError.ForeColor = Color.Red;
            lbl_signInPassError.Location = new Point(393, 8);
            lbl_signInPassError.Name = "lbl_signInPassError";
            lbl_signInPassError.Size = new Size(21, 28);
            lbl_signInPassError.TabIndex = 0;
            lbl_signInPassError.Text = "!";
            toolTip1.SetToolTip(lbl_signInPassError, "Enter your password.");
            lbl_signInPassError.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = InventoryManagmentSystem.PL.Properties.Resources.password_7309482;
            pictureBox3.Location = new Point(15, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lbl_signInUserError);
            panel3.Controls.Add(txt_signinName);
            panel3.Controls.Add(pictureBox4);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(0, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 45);
            panel3.TabIndex = 0;
            // 
            // lbl_signInUserError
            // 
            lbl_signInUserError.AutoSize = true;
            lbl_signInUserError.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signInUserError.ForeColor = Color.Red;
            lbl_signInUserError.Location = new Point(393, 8);
            lbl_signInUserError.Name = "lbl_signInUserError";
            lbl_signInUserError.Size = new Size(21, 28);
            lbl_signInUserError.TabIndex = 1;
            lbl_signInUserError.Text = "!";
            toolTip1.SetToolTip(lbl_signInUserError, "Enter your username");
            lbl_signInUserError.Visible = false;
            // 
            // txt_signinName
            // 
            txt_signinName.BorderStyle = BorderStyle.None;
            txt_signinName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signinName.ForeColor = Color.FromArgb(39, 59, 122);
            txt_signinName.Location = new Point(62, 11);
            txt_signinName.Name = "txt_signinName";
            txt_signinName.PlaceholderText = "Username";
            txt_signinName.Size = new Size(316, 25);
            txt_signinName.TabIndex = 1;
            toolTip1.SetToolTip(txt_signinName, "Enter your username.");
            txt_signinName.Click += txt_signinName_Click;
            txt_signinName.TextChanged += txt_signinName_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = InventoryManagmentSystem.PL.Properties.Resources.person_12047661;
            pictureBox4.Location = new Point(15, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lbl_signInerrorMsg
            // 
            lbl_signInerrorMsg.AutoSize = true;
            lbl_signInerrorMsg.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_signInerrorMsg.ForeColor = Color.DarkRed;
            lbl_signInerrorMsg.Location = new Point(82, 115);
            lbl_signInerrorMsg.Name = "lbl_signInerrorMsg";
            lbl_signInerrorMsg.Size = new Size(19, 25);
            lbl_signInerrorMsg.TabIndex = 0;
            lbl_signInerrorMsg.Text = " ";
            lbl_signInerrorMsg.Visible = false;
            // 
            // btn_signInReset
            // 
            btn_signInReset.BackColor = Color.FromArgb(254, 112, 98);
            btn_signInReset.BorderColor = Color.Transparent;
            btn_signInReset.BorderRadius = 17;
            btn_signInReset.BorderSize = 0;
            btn_signInReset.FlatAppearance.BorderSize = 0;
            btn_signInReset.FlatStyle = FlatStyle.Flat;
            btn_signInReset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_signInReset.ForeColor = Color.White;
            btn_signInReset.Location = new Point(215, 325);
            btn_signInReset.Name = "btn_signInReset";
            btn_signInReset.Size = new Size(159, 42);
            btn_signInReset.TabIndex = 6;
            btn_signInReset.Text = "RESET";
            btn_signInReset.UseVisualStyleBackColor = false;
            btn_signInReset.Click += btn_signInReset_Click;
            btn_signInReset.MouseEnter += btn_signInReset_MouseEnter;
            btn_signInReset.MouseLeave += btn_signInReset_MouseLeave;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(254, 112, 98);
            btn_login.BorderColor = Color.Transparent;
            btn_login.BorderRadius = 17;
            btn_login.BorderSize = 0;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(33, 324);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(159, 42);
            btn_login.TabIndex = 5;
            btn_login.Text = "LOG IN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.MouseEnter += btn_login_MouseEnter;
            btn_login.MouseLeave += btn_login_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = InventoryManagmentSystem.PL.Properties.Resources._12085707_20944201;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 490);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(840, 490);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_signin;
        private Label label1;
        private Panel panel2;
        private TextBox txt_signinPass;
        private Label lbl_signInPassError;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label lbl_signInUserError;
        private TextBox txt_signinName;
        private PictureBox pictureBox4;
        private Label lbl_signInerrorMsg;
        private ToolTip toolTip1;
        private CustomControls.RoundedButton btn_signInReset;
        private CustomControls.RoundedButton btn_login;
    }
}