namespace uni6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsvContent = new ListView();
            txtName = new TextBox();
            txtScience = new TextBox();
            txtEnglish = new TextBox();
            txtMathematics = new TextBox();
            txtSpanish = new TextBox();
            lblName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCalificaciones = new Label();
            lblSubjcts = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPhysics = new TextBox();
            label8 = new Label();
            txtAvarage = new TextBox();
            ibtnCalculateAvarage = new FontAwesome.Sharp.IconButton();
            ibtnSave = new FontAwesome.Sharp.IconButton();
            ibtnSaveTxt = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lsvContent
            // 
            lsvContent.Location = new Point(257, 12);
            lsvContent.Name = "lsvContent";
            lsvContent.Size = new Size(602, 157);
            lsvContent.TabIndex = 1;
            lsvContent.UseCompatibleStateImageBehavior = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 23);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 22);
            txtName.TabIndex = 2;
            // 
            // txtScience
            // 
            txtScience.Location = new Point(113, 177);
            txtScience.Multiline = true;
            txtScience.Name = "txtScience";
            txtScience.Size = new Size(121, 22);
            txtScience.TabIndex = 3;
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(113, 147);
            txtEnglish.Multiline = true;
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(121, 22);
            txtEnglish.TabIndex = 4;
            // 
            // txtMathematics
            // 
            txtMathematics.Location = new Point(114, 121);
            txtMathematics.Multiline = true;
            txtMathematics.Name = "txtMathematics";
            txtMathematics.Size = new Size(121, 22);
            txtMathematics.TabIndex = 5;
            // 
            // txtSpanish
            // 
            txtSpanish.Location = new Point(113, 93);
            txtSpanish.Multiline = true;
            txtSpanish.Name = "txtSpanish";
            txtSpanish.Size = new Size(121, 22);
            txtSpanish.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 179);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 149);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 9;
            label2.Text = "English";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 10;
            label3.Text = "Mathematics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "Spanish";
            // 
            // lblCalificaciones
            // 
            lblCalificaciones.AutoSize = true;
            lblCalificaciones.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalificaciones.Location = new Point(113, 61);
            lblCalificaciones.Name = "lblCalificaciones";
            lblCalificaciones.Size = new Size(96, 20);
            lblCalificaciones.TabIndex = 12;
            lblCalificaciones.Text = "Qualification";
            // 
            // lblSubjcts
            // 
            lblSubjcts.AutoSize = true;
            lblSubjcts.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubjcts.Location = new Point(11, 61);
            lblSubjcts.Name = "lblSubjcts";
            lblSubjcts.Size = new Size(65, 20);
            lblSubjcts.TabIndex = 13;
            lblSubjcts.Text = "Subjects";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 176);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 14;
            label6.Text = "Science";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 205);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 15;
            label7.Text = "Physics";
            // 
            // txtPhysics
            // 
            txtPhysics.Location = new Point(113, 205);
            txtPhysics.Multiline = true;
            txtPhysics.Name = "txtPhysics";
            txtPhysics.Size = new Size(121, 22);
            txtPhysics.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 257);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 17;
            label8.Text = "Avarage";
            // 
            // txtAvarage
            // 
            txtAvarage.Location = new Point(114, 255);
            txtAvarage.Multiline = true;
            txtAvarage.Name = "txtAvarage";
            txtAvarage.ReadOnly = true;
            txtAvarage.Size = new Size(121, 22);
            txtAvarage.TabIndex = 18;
            // 
            // ibtnCalculateAvarage
            // 
            ibtnCalculateAvarage.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            ibtnCalculateAvarage.IconColor = Color.Black;
            ibtnCalculateAvarage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCalculateAvarage.Location = new Point(257, 214);
            ibtnCalculateAvarage.Name = "ibtnCalculateAvarage";
            ibtnCalculateAvarage.Size = new Size(49, 63);
            ibtnCalculateAvarage.TabIndex = 19;
            ibtnCalculateAvarage.UseVisualStyleBackColor = true;
            ibtnCalculateAvarage.Click += ibtnCalculateAvarage_Click;
            // 
            // ibtnSave
            // 
            ibtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnSave.IconColor = Color.Black;
            ibtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSave.Location = new Point(314, 214);
            ibtnSave.Name = "ibtnSave";
            ibtnSave.Size = new Size(49, 63);
            ibtnSave.TabIndex = 20;
            ibtnSave.UseVisualStyleBackColor = true;
            ibtnSave.Click += ibtnSave_Click;
            // 
            // ibtnSaveTxt
            // 
            ibtnSaveTxt.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnSaveTxt.IconColor = Color.Black;
            ibtnSaveTxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSaveTxt.Location = new Point(369, 214);
            ibtnSaveTxt.Name = "ibtnSaveTxt";
            ibtnSaveTxt.Size = new Size(49, 63);
            ibtnSaveTxt.TabIndex = 21;
            ibtnSaveTxt.Text = "Txt";
            ibtnSaveTxt.TextAlign = ContentAlignment.BottomCenter;
            ibtnSaveTxt.UseVisualStyleBackColor = true;
            ibtnSaveTxt.Click += ibtnSaveTxt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 450);
            Controls.Add(ibtnSaveTxt);
            Controls.Add(ibtnSave);
            Controls.Add(ibtnCalculateAvarage);
            Controls.Add(txtAvarage);
            Controls.Add(label8);
            Controls.Add(txtPhysics);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblSubjcts);
            Controls.Add(lblCalificaciones);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(txtSpanish);
            Controls.Add(txtMathematics);
            Controls.Add(txtEnglish);
            Controls.Add(txtScience);
            Controls.Add(txtName);
            Controls.Add(lsvContent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lsvContent;
        private TextBox txtName;
        private TextBox txtScience;
        private TextBox txtEnglish;
        private TextBox txtMathematics;
        private TextBox txtSpanish;
        private Label lblName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCalificaciones;
        private Label lblSubjcts;
        private Label label6;
        private Label label7;
        private TextBox txtPhysics;
        private Label label8;
        private TextBox txtAvarage;
        private FontAwesome.Sharp.IconButton ibtnCalculateAvarage;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private FontAwesome.Sharp.IconButton ibtnSaveTxt;
    }
}
