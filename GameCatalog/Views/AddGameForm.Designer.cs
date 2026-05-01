namespace GameCatalog
{
    partial class AddGameForm
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
            txtTitle = new TextBox();
            txtGenre = new TextBox();
            txtDeveloper = new TextBox();
            txtPlatform = new TextBox();
            txtPrice = new TextBox();
            rbPC = new RadioButton();
            rbOnline = new RadioButton();
            txtPlayers = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(48, 55);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(296, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(48, 126);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(296, 27);
            txtGenre.TabIndex = 1;
            // 
            // txtDeveloper
            // 
            txtDeveloper.Location = new Point(48, 194);
            txtDeveloper.Name = "txtDeveloper";
            txtDeveloper.Size = new Size(296, 27);
            txtDeveloper.TabIndex = 2;
            // 
            // txtPlatform
            // 
            txtPlatform.Location = new Point(48, 259);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(296, 27);
            txtPlatform.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(48, 321);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(296, 27);
            txtPrice.TabIndex = 4;
            // 
            // rbPC
            // 
            rbPC.AutoSize = true;
            rbPC.Location = new Point(539, 58);
            rbPC.Name = "rbPC";
            rbPC.Size = new Size(90, 24);
            rbPC.TabIndex = 5;
            rbPC.TabStop = true;
            rbPC.Text = "PC Game";
            rbPC.UseVisualStyleBackColor = true;
            // 
            // rbOnline
            // 
            rbOnline.AutoSize = true;
            rbOnline.Location = new Point(539, 88);
            rbOnline.Name = "rbOnline";
            rbOnline.Size = new Size(116, 24);
            rbOnline.TabIndex = 6;
            rbOnline.TabStop = true;
            rbOnline.Text = "Online Game";
            rbOnline.UseVisualStyleBackColor = true;
            // 
            // txtPlayers
            // 
            txtPlayers.Location = new Point(500, 215);
            txtPlayers.Name = "txtPlayers";
            txtPlayers.Size = new Size(208, 27);
            txtPlayers.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(500, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 83);
            btnSave.TabIndex = 8;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(500, 192);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 9;
            label1.Text = "Кількість гравців:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 32);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 10;
            label2.Text = "Назва:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 11;
            label3.Text = "Жанр:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 171);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 12;
            label4.Text = "Розробник:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 236);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 13;
            label5.Text = "Платформа:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 298);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 14;
            label6.Text = "Ціна:";
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtPlayers);
            Controls.Add(rbOnline);
            Controls.Add(rbPC);
            Controls.Add(txtPrice);
            Controls.Add(txtPlatform);
            Controls.Add(txtDeveloper);
            Controls.Add(txtGenre);
            Controls.Add(txtTitle);
            Name = "AddGameForm";
            Text = "Add Video Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtGenre;
        private TextBox txtDeveloper;
        private TextBox txtPlatform;
        private TextBox txtPrice;
        private RadioButton rbPC;
        private RadioButton rbOnline;
        private TextBox txtPlayers;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}