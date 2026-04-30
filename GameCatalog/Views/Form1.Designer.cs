namespace GameCatalog
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
            dgvGames = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFilterPC = new Button();
            btnSortPrice = new Button();
            btnFindCheapest = new Button();
            btnCalculateDiscount = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Location = new Point(38, 45);
            dgvGames.Name = "dgvGames";
            dgvGames.RowHeadersWidth = 51;
            dgvGames.Size = new Size(540, 360);
            dgvGames.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(625, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(625, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFilterPC
            // 
            btnFilterPC.Location = new Point(625, 165);
            btnFilterPC.Name = "btnFilterPC";
            btnFilterPC.Size = new Size(94, 29);
            btnFilterPC.TabIndex = 3;
            btnFilterPC.Text = "button3";
            btnFilterPC.UseVisualStyleBackColor = true;
            btnFilterPC.Click += btnFilterPC_Click;
            // 
            // btnSortPrice
            // 
            btnSortPrice.Location = new Point(625, 223);
            btnSortPrice.Name = "btnSortPrice";
            btnSortPrice.Size = new Size(94, 29);
            btnSortPrice.TabIndex = 4;
            btnSortPrice.Text = "button4";
            btnSortPrice.UseVisualStyleBackColor = true;
            btnSortPrice.Click += btnSortPrice_Click;
            // 
            // btnFindCheapest
            // 
            btnFindCheapest.Location = new Point(625, 280);
            btnFindCheapest.Name = "btnFindCheapest";
            btnFindCheapest.Size = new Size(94, 29);
            btnFindCheapest.TabIndex = 5;
            btnFindCheapest.Text = "button5";
            btnFindCheapest.UseVisualStyleBackColor = true;
            btnFindCheapest.Click += btnFindCheapest_Click;
            // 
            // btnCalculateDiscount
            // 
            btnCalculateDiscount.Location = new Point(625, 332);
            btnCalculateDiscount.Name = "btnCalculateDiscount";
            btnCalculateDiscount.Size = new Size(94, 29);
            btnCalculateDiscount.TabIndex = 6;
            btnCalculateDiscount.Text = "button6";
            btnCalculateDiscount.UseVisualStyleBackColor = true;
            btnCalculateDiscount.Click += btnCalculateDiscount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculateDiscount);
            Controls.Add(btnFindCheapest);
            Controls.Add(btnSortPrice);
            Controls.Add(btnFilterPC);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvGames);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGames;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFilterPC;
        private Button btnSortPrice;
        private Button btnFindCheapest;
        private Button btnCalculateDiscount;
    }
}
