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
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(125, 58);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(136, 118);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 27);
            txtGenre.TabIndex = 1;
            // 
            // txtDeveloper
            // 
            txtDeveloper.Location = new Point(165, 182);
            txtDeveloper.Name = "txtDeveloper";
            txtDeveloper.Size = new Size(125, 27);
            txtDeveloper.TabIndex = 2;
            // 
            // txtPlatform
            // 
            txtPlatform.Location = new Point(188, 240);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(125, 27);
            txtPlatform.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(207, 295);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 4;
            // 
            // rbPC
            // 
            rbPC.AutoSize = true;
            rbPC.Location = new Point(485, 84);
            rbPC.Name = "rbPC";
            rbPC.Size = new Size(117, 24);
            rbPC.TabIndex = 5;
            rbPC.TabStop = true;
            rbPC.Text = "radioButton1";
            rbPC.UseVisualStyleBackColor = true;
            // 
            // rbOnline
            // 
            rbOnline.AutoSize = true;
            rbOnline.Location = new Point(488, 129);
            rbOnline.Name = "rbOnline";
            rbOnline.Size = new Size(117, 24);
            rbOnline.TabIndex = 6;
            rbOnline.TabStop = true;
            rbOnline.Text = "radioButton2";
            rbOnline.UseVisualStyleBackColor = true;
            // 
            // txtPlayers
            // 
            txtPlayers.Location = new Point(529, 189);
            txtPlayers.Name = "txtPlayers";
            txtPlayers.Size = new Size(125, 27);
            txtPlayers.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(579, 257);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "AddGameForm";
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
    }
}