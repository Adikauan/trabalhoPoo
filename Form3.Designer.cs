﻿namespace Cadastro_de_maquinas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pbxCreate = new PictureBox();
            panel1_1 = new Panel();
            panel3_1 = new Panel();
            Label1_1 = new Label();
            btnCancel = new Button();
            label1 = new Label();
            textName = new TextBox();
            textType = new TextBox();
            label2 = new Label();
            txtDynProp1_key = new TextBox();
            txtDynProp1_val = new TextBox();
            txtDynProp2_val = new TextBox();
            txtDynProp3_val = new TextBox();
            txtDynProp2_key = new TextBox();
            txtDynProp3_key = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnAdd1 = new PictureBox();
            btnAdd2 = new PictureBox();
            btnAdd3 = new PictureBox();
            btnDel2 = new PictureBox();
            btnDel3 = new PictureBox();
            btnDel4 = new PictureBox();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnUpdateImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxCreate).BeginInit();
            panel3_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDel4).BeginInit();
            SuspendLayout();
            // 
            // pbxCreate
            // 
            pbxCreate.BackColor = Color.White;
            pbxCreate.BorderStyle = BorderStyle.FixedSingle;
            pbxCreate.Cursor = Cursors.Hand;
            pbxCreate.Location = new Point(69, 198);
            pbxCreate.Name = "pbxCreate";
            pbxCreate.Size = new Size(286, 214);
            pbxCreate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCreate.TabIndex = 4;
            pbxCreate.TabStop = false;
            pbxCreate.WaitOnLoad = true;
            pbxCreate.Click += pbxCreate_Click;
            // 
            // panel1_1
            // 
            panel1_1.BackColor = Color.FromArgb(77, 83, 83);
            panel1_1.BorderStyle = BorderStyle.FixedSingle;
            panel1_1.Dock = DockStyle.Top;
            panel1_1.Location = new Point(0, 0);
            panel1_1.Name = "panel1_1";
            panel1_1.Size = new Size(1184, 50);
            panel1_1.TabIndex = 2;
            // 
            // panel3_1
            // 
            panel3_1.BackColor = Color.FromArgb(236, 236, 236);
            panel3_1.Controls.Add(Label1_1);
            panel3_1.Location = new Point(0, 50);
            panel3_1.Name = "panel3_1";
            panel3_1.Size = new Size(1185, 50);
            panel3_1.TabIndex = 3;
            // 
            // Label1_1
            // 
            Label1_1.AutoSize = true;
            Label1_1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            Label1_1.Location = new Point(12, 12);
            Label1_1.Name = "Label1_1";
            Label1_1.Size = new Size(219, 25);
            Label1_1.TabIndex = 0;
            Label1_1.Text = "Cadastro de Máquina";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(77, 83, 83);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(938, 600);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(392, 222);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // textName
            // 
            textName.BorderStyle = BorderStyle.FixedSingle;
            textName.Location = new Point(474, 220);
            textName.Name = "textName";
            textName.Size = new Size(400, 23);
            textName.TabIndex = 8;
            // 
            // textType
            // 
            textType.BorderStyle = BorderStyle.FixedSingle;
            textType.Location = new Point(474, 280);
            textType.Name = "textType";
            textType.Size = new Size(400, 23);
            textType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(392, 282);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 7;
            label2.Text = "Tipo:";
            // 
            // txtDynProp1_key
            // 
            txtDynProp1_key.BorderStyle = BorderStyle.FixedSingle;
            txtDynProp1_key.Location = new Point(392, 340);
            txtDynProp1_key.Name = "txtDynProp1_key";
            txtDynProp1_key.Size = new Size(76, 23);
            txtDynProp1_key.TabIndex = 11;
            txtDynProp1_key.Visible = false;
            // 
            // txtDynProp1_val
            // 
            txtDynProp1_val.BorderStyle = BorderStyle.FixedSingle;
            txtDynProp1_val.Location = new Point(474, 340);
            txtDynProp1_val.Name = "txtDynProp1_val";
            txtDynProp1_val.Size = new Size(400, 23);
            txtDynProp1_val.TabIndex = 12;
            txtDynProp1_val.Visible = false;
            // 
            // txtDynProp2_val
            // 
            txtDynProp2_val.BorderStyle = BorderStyle.FixedSingle;
            txtDynProp2_val.Location = new Point(474, 400);
            txtDynProp2_val.Name = "txtDynProp2_val";
            txtDynProp2_val.Size = new Size(400, 23);
            txtDynProp2_val.TabIndex = 13;
            txtDynProp2_val.Visible = false;
            // 
            // txtDynProp3_val
            // 
            txtDynProp3_val.BorderStyle = BorderStyle.FixedSingle;
            txtDynProp3_val.Location = new Point(474, 460);
            txtDynProp3_val.Name = "txtDynProp3_val";
            txtDynProp3_val.Size = new Size(400, 23);
            txtDynProp3_val.TabIndex = 14;
            txtDynProp3_val.Visible = false;
            // 
            // txtDynProp2_key
            // 
            txtDynProp2_key.BorderStyle = BorderStyle.FixedSingle;
            txtDynProp2_key.Location = new Point(392, 400);
            txtDynProp2_key.Name = "txtDynProp2_key";
            txtDynProp2_key.Size = new Size(76, 23);
            txtDynProp2_key.TabIndex = 15;
            txtDynProp2_key.Visible = false;
            // 
            // txtDynProp3_key
            // 
            txtDynProp3_key.BorderStyle = BorderStyle.FixedSingle;
            txtDynProp3_key.Location = new Point(392, 460);
            txtDynProp3_key.Name = "txtDynProp3_key";
            txtDynProp3_key.Size = new Size(76, 23);
            txtDynProp3_key.TabIndex = 16;
            txtDynProp3_key.Visible = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(392, 179);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 17;
            label3.Text = "Chave";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(474, 179);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 18;
            label4.Text = "Valor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd1
            // 
            btnAdd1.BackColor = Color.FromArgb(77, 83, 83);
            btnAdd1.Cursor = Cursors.Hand;
            btnAdd1.Image = (Image)resources.GetObject("btnAdd1.Image");
            btnAdd1.Location = new Point(900, 280);
            btnAdd1.Margin = new Padding(5);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(50, 23);
            btnAdd1.SizeMode = PictureBoxSizeMode.CenterImage;
            btnAdd1.TabIndex = 19;
            btnAdd1.TabStop = false;
            btnAdd1.Click += btnAdd_Click;
            // 
            // btnAdd2
            // 
            btnAdd2.BackColor = Color.FromArgb(77, 83, 83);
            btnAdd2.Cursor = Cursors.Hand;
            btnAdd2.Image = (Image)resources.GetObject("btnAdd2.Image");
            btnAdd2.Location = new Point(900, 340);
            btnAdd2.Margin = new Padding(5);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(50, 23);
            btnAdd2.SizeMode = PictureBoxSizeMode.CenterImage;
            btnAdd2.TabIndex = 20;
            btnAdd2.TabStop = false;
            btnAdd2.Visible = false;
            btnAdd2.Click += btnAdd2_Click;
            // 
            // btnAdd3
            // 
            btnAdd3.BackColor = Color.FromArgb(77, 83, 83);
            btnAdd3.Cursor = Cursors.Hand;
            btnAdd3.Image = (Image)resources.GetObject("btnAdd3.Image");
            btnAdd3.Location = new Point(900, 400);
            btnAdd3.Margin = new Padding(5);
            btnAdd3.Name = "btnAdd3";
            btnAdd3.Size = new Size(50, 23);
            btnAdd3.SizeMode = PictureBoxSizeMode.CenterImage;
            btnAdd3.TabIndex = 21;
            btnAdd3.TabStop = false;
            btnAdd3.Visible = false;
            btnAdd3.Click += btnAdd3_Click;
            // 
            // btnDel2
            // 
            btnDel2.BackColor = Color.FromArgb(77, 83, 83);
            btnDel2.Cursor = Cursors.Hand;
            btnDel2.Image = (Image)resources.GetObject("btnDel2.Image");
            btnDel2.Location = new Point(960, 340);
            btnDel2.Margin = new Padding(5);
            btnDel2.Name = "btnDel2";
            btnDel2.Size = new Size(50, 23);
            btnDel2.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDel2.TabIndex = 24;
            btnDel2.TabStop = false;
            btnDel2.Visible = false;
            btnDel2.Click += btnDel2_Click;
            // 
            // btnDel3
            // 
            btnDel3.BackColor = Color.FromArgb(77, 83, 83);
            btnDel3.Cursor = Cursors.Hand;
            btnDel3.Image = (Image)resources.GetObject("btnDel3.Image");
            btnDel3.Location = new Point(960, 400);
            btnDel3.Margin = new Padding(5);
            btnDel3.Name = "btnDel3";
            btnDel3.Size = new Size(50, 23);
            btnDel3.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDel3.TabIndex = 25;
            btnDel3.TabStop = false;
            btnDel3.Visible = false;
            btnDel3.Click += btnDel3_Click;
            // 
            // btnDel4
            // 
            btnDel4.BackColor = Color.FromArgb(77, 83, 83);
            btnDel4.Cursor = Cursors.Hand;
            btnDel4.Image = (Image)resources.GetObject("btnDel4.Image");
            btnDel4.Location = new Point(960, 460);
            btnDel4.Margin = new Padding(5);
            btnDel4.Name = "btnDel4";
            btnDel4.Size = new Size(50, 23);
            btnDel4.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDel4.TabIndex = 26;
            btnDel4.TabStop = false;
            btnDel4.Visible = false;
            btnDel4.Click += btnDel4_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(77, 83, 83);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1058, 600);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 34);
            btnSave.TabIndex = 27;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpdateImage
            // 
            btnUpdateImage.BackColor = Color.FromArgb(77, 83, 83);
            btnUpdateImage.Cursor = Cursors.Hand;
            btnUpdateImage.FlatStyle = FlatStyle.Flat;
            btnUpdateImage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateImage.ForeColor = Color.White;
            btnUpdateImage.Location = new Point(211, 418);
            btnUpdateImage.Name = "btnUpdateImage";
            btnUpdateImage.Size = new Size(144, 34);
            btnUpdateImage.TabIndex = 28;
            btnUpdateImage.Text = "ALTERAR IMAGEM";
            btnUpdateImage.UseVisualStyleBackColor = false;
            btnUpdateImage.Visible = false;
            btnUpdateImage.Click += btnUpdateImage_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1184, 646);
            Controls.Add(btnUpdateImage);
            Controls.Add(btnSave);
            Controls.Add(btnDel4);
            Controls.Add(btnDel3);
            Controls.Add(btnDel2);
            Controls.Add(btnAdd3);
            Controls.Add(btnAdd2);
            Controls.Add(btnAdd1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDynProp3_key);
            Controls.Add(txtDynProp2_key);
            Controls.Add(txtDynProp3_val);
            Controls.Add(txtDynProp2_val);
            Controls.Add(txtDynProp1_val);
            Controls.Add(txtDynProp1_key);
            Controls.Add(textType);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(pbxCreate);
            Controls.Add(panel3_1);
            Controls.Add(panel1_1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pbxCreate).EndInit();
            panel3_1.ResumeLayout(false);
            panel3_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDel4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1_1;
        private Panel panel3_1;
        private Label Label1_1;
        private PictureBox pbxCreate;
        private Button btnCancel;
        private Label label1;
        private TextBox textName;
        private TextBox textType;
        private Label label2;
        private TextBox txtDynProp1_key;
        private TextBox txtDynProp1_val;
        private TextBox txtDynProp2_val;
        private TextBox txtDynProp3_val;
        private TextBox txtDynProp2_key;
        private TextBox txtDynProp3_key;
        private Label label3;
        private Label label4;
        private PictureBox btnAdd1;
        private PictureBox btnAdd2;
        private PictureBox btnAdd3;
        private PictureBox btnDel2;
        private PictureBox btnDel3;
        private PictureBox btnDel4;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private Button btnUpdateImage;
    }
}