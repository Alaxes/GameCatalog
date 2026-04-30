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
            rbPC.Checked = true; // За замовчуванням обрана ПК-гра
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
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