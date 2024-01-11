namespace Gym_Management_System
{
    partial class ViewMember
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MemberSDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button4 = new Button();
            SearchMember = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            button2 = new Button();
            label11 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1340, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 37);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(572, 46);
            label2.Name = "label2";
            label2.Size = new Size(215, 37);
            label2.TabIndex = 6;
            label2.Text = "MEMBERS LIST";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(562, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 5;
            label1.Text = "FITNESS CENTER";
            // 
            // MemberSDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            MemberSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MemberSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MemberSDGV.ColumnHeadersHeight = 30;
            MemberSDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MemberSDGV.DefaultCellStyle = dataGridViewCellStyle3;
            MemberSDGV.GridColor = Color.FromArgb(231, 229, 255);
            MemberSDGV.Location = new Point(167, 155);
            MemberSDGV.Name = "MemberSDGV";
            MemberSDGV.RowHeadersVisible = false;
            MemberSDGV.RowHeadersWidth = 51;
            MemberSDGV.RowTemplate.Height = 25;
            MemberSDGV.Size = new Size(1127, 481);
            MemberSDGV.TabIndex = 49;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            MemberSDGV.ThemeStyle.BackColor = Color.White;
            MemberSDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            MemberSDGV.ThemeStyle.HeaderStyle.BackColor = Color.MediumBlue;
            MemberSDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            MemberSDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MemberSDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            MemberSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MemberSDGV.ThemeStyle.HeaderStyle.Height = 30;
            MemberSDGV.ThemeStyle.ReadOnly = false;
            MemberSDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            MemberSDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MemberSDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MemberSDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            MemberSDGV.ThemeStyle.RowsStyle.Height = 25;
            MemberSDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Crimson;
            MemberSDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            MemberSDGV.CellContentClick += MemberSDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(699, 100);
            button4.Name = "button4";
            button4.Size = new Size(191, 49);
            button4.TabIndex = 51;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // SearchMember
            // 
            SearchMember.BorderColor = Color.Black;
            SearchMember.BorderThickness = 2;
            SearchMember.CustomizableEdges = customizableEdges1;
            SearchMember.DefaultText = "";
            SearchMember.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchMember.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchMember.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchMember.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchMember.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchMember.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchMember.ForeColor = Color.Crimson;
            SearchMember.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchMember.Location = new Point(459, 100);
            SearchMember.Margin = new Padding(4, 3, 4, 3);
            SearchMember.Name = "SearchMember";
            SearchMember.PasswordChar = '\0';
            SearchMember.PlaceholderForeColor = Color.Crimson;
            SearchMember.PlaceholderText = "";
            SearchMember.SelectedText = "";
            SearchMember.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchMember.Size = new Size(246, 49);
            SearchMember.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            SearchMember.TabIndex = 50;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(896, 100);
            button1.Name = "button1";
            button1.Size = new Size(191, 49);
            button1.TabIndex = 52;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(650, 642);
            button2.Name = "button2";
            button2.Size = new Size(191, 49);
            button2.TabIndex = 53;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(564, 740);
            label11.Name = "label11";
            label11.Size = new Size(372, 27);
            label11.TabIndex = 55;
            label11.Text = "Conect: Hadi.Alk@Hotmail.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(611, 712);
            label10.Name = "label10";
            label10.Size = new Size(279, 27);
            label10.TabIndex = 54;
            label10.Text = "Developed By Scorpion";
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 789);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(SearchMember);
            Controls.Add(MemberSDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMember";
            Load += ViewMember_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView MemberSDGV;
        private Button button4;
        private Guna.UI2.WinForms.Guna2TextBox SearchMember;
        private Button button1;
        private Button button2;
        private Label label11;
        private Label label10;
    }
}