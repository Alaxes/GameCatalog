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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Location = new Point(37, 37);
            dgvGames.Name = "dgvGames";
            dgvGames.RowHeadersWidth = 51;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(540, 360);
            dgvGames.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(625, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати гру";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(625, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити гру";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFilterPC
            // 
            btnFilterPC.Location = new Point(625, 165);
            btnFilterPC.Name = "btnFilterPC";
            btnFilterPC.Size = new Size(155, 29);
            btnFilterPC.TabIndex = 3;
            btnFilterPC.Text = "Фільтр ПК\\Онлайн";
            btnFilterPC.UseVisualStyleBackColor = true;
            btnFilterPC.Click += btnFilterPC_Click;
            // 
            // btnSortPrice
            // 
            btnSortPrice.Location = new Point(625, 223);
            btnSortPrice.Name = "btnSortPrice";
            btnSortPrice.Size = new Size(155, 29);
            btnSortPrice.TabIndex = 4;
            btnSortPrice.Text = "Сортування";
            btnSortPrice.UseVisualStyleBackColor = true;
            btnSortPrice.Click += btnSortPrice_Click;
            // 
            // btnFindCheapest
            // 
            btnFindCheapest.Location = new Point(625, 280);
            btnFindCheapest.Name = "btnFindCheapest";
            btnFindCheapest.Size = new Size(155, 29);
            btnFindCheapest.TabIndex = 5;
            btnFindCheapest.Text = "Найдешевша гра";
            btnFindCheapest.UseVisualStyleBackColor = true;
            btnFindCheapest.Click += btnFindCheapest_Click;
            // 
            // btnCalculateDiscount
            // 
            btnCalculateDiscount.Location = new Point(625, 336);
            btnCalculateDiscount.Name = "btnCalculateDiscount";
            btnCalculateDiscount.Size = new Size(155, 29);
            btnCalculateDiscount.TabIndex = 6;
            btnCalculateDiscount.Text = "Знижка";
            btnCalculateDiscount.UseVisualStyleBackColor = true;
            btnCalculateDiscount.Click += btnCalculateDiscount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 7;
            label1.Text = "Каталог ігор";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCalculateDiscount);
            Controls.Add(btnFindCheapest);
            Controls.Add(btnSortPrice);
            Controls.Add(btnFilterPC);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvGames);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Game Catalog";
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGames;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFilterPC;
        private Button btnSortPrice;
        private Button btnFindCheapest;
        private Button btnCalculateDiscount;
        private Label label1;
    }
}
