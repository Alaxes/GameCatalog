using System;
using System.Windows.Forms;
using GameCatalog.Models;

namespace GameCatalog
{
    public partial class AddGameForm : Form
    {
        // Публічна властивість, куди ми збережемо створену гру, щоб Form1 могла її забрати
        public Game NewGame { get; private set; }

        public AddGameForm()
        {
            InitializeComponent();
            ApplyModernTheme();
            rbPC.Checked = true; // За замовчуванням обрана ПК-гра
        }
        private void ApplyModernTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(39, 41, 45);
            this.ForeColor = System.Drawing.Color.White;

            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = System.Drawing.Color.FromArgb(23, 26, 33);
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Cursor = Cursors.Hand;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = System.Drawing.Color.FromArgb(23, 26, 33);
                    txt.ForeColor = System.Drawing.Color.White;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is RadioButton rb)
                {
                    rb.ForeColor = System.Drawing.Color.White;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = System.Drawing.Color.White;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Перевірка: якщо вибрано ПК-гру, поле "Кількість гравців" МАЄ бути пустим
                if (rbPC.Checked && !string.IsNullOrWhiteSpace(txtPlayers.Text))
                {
                    MessageBox.Show("Помилка: Кількість гравців можна вказувати ТІЛЬКИ для онлайн-ігор! Очистіть це поле.",
                                    "Помилка вводу",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Зупиняємо виконання методу, гра не зберігається
                }

                // Зчитуємо базові дані
                string title = txtTitle.Text;
                string genre = txtGenre.Text;
                string dev = txtDeveloper.Text;
                string platform = txtPlatform.Text;
                decimal price = decimal.Parse(txtPrice.Text); // Перетворюємо текст на гроші

                // Створюємо гру залежно від того, що вибрав користувач
                if (rbPC.Checked)
                {
                    NewGame = new PCGame(genre, title, dev, platform, price);
                }
                else if (rbOnline.Checked)
                {
                    int players = int.Parse(txtPlayers.Text); // Перетворюємо текст на число гравців
                    NewGame = new OnlineGame(genre, title, dev, platform, price, players);
                }

                // Кажемо, що все пройшло успішно, і закриваємо віконце
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                // Якщо користувач ввів літери замість цифр у ціну або кількість гравців
                MessageBox.Show("Будь ласка, перевірте правильність введених даних. Ціна та кількість гравців мають бути числами.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}