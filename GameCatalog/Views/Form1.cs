using System;
using System.Windows.Forms;
using GameCatalog.Models; // Підключаємо наші класи
using System.Linq;

namespace GameCatalog
{
    public partial class Form1 : Form
    {
        // Створюємо екземпляр нашого менеджера
        private GameManager manager;
        // Вказуємо назву файлу, де будуть зберігатися дані
        private string filePath = "games.txt";

        public Form1()
        {
            InitializeComponent();

            // Ініціалізуємо менеджер
            manager = new GameManager();

            // При запуску програми намагаємося завантажити дані з файлу
            manager.LoadFromFile(filePath);

            // Виводимо дані в таблицю
            RefreshGrid();
        }

        // Спеціальний метод для оновлення таблиці (ми будемо викликати його часто)
        private void RefreshGrid()
        {
            // Відв'язуємо старі дані
            dgvGames.DataSource = null;
            // Прив'язуємо список ігор з менеджера
            dgvGames.DataSource = manager.GetAllGames();

            // Робимо таблицю красивішою: налаштовуємо авторозмір колонок
            dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Створюємо наше нове віконце для додавання
            AddGameForm form = new AddGameForm();

            // Показуємо його. Якщо користувач натиснув "Зберегти" і все пройшло успішно (OK)...
            if (form.ShowDialog() == DialogResult.OK)
            {
                // ...то беремо створену гру з тієї форми і додаємо в наш менеджер
                manager.AddGame(form.NewGame);

                // Одразу зберігаємо у файл і оновлюємо таблицю
                manager.SaveToFile(filePath);
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи виділено хоча б один рядок у таблиці
            if (dgvGames.SelectedRows.Count > 0)
            {
                // Отримуємо назву гри з виділеного рядка (значення колонки Title)
                string title = dgvGames.SelectedRows[0].Cells["Title"].Value.ToString();

                manager.DeleteGame(title);   // Видаляємо з менеджера
                manager.SaveToFile(filePath); // Одразу зберігаємо зміни у файл
                RefreshGrid();                // Оновлюємо таблицю на екрані
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок для видалення (натисніть на стрілочку зліва від рядка).", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFilterPC_Click(object sender, EventArgs e)
        {
            // Шукаємо тільки ті ігри, які належать до класу PCGame
            var pcGames = manager.GetAllGames().Where(g => g is PCGame).ToList();

            // Оновлюємо таблицю новими даними
            dgvGames.DataSource = null;
            dgvGames.DataSource = pcGames;
        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            // Сортуємо список за зростанням ціни
            var sortedGames = manager.GetAllGames().OrderBy(g => g.Price).ToList();

            dgvGames.DataSource = null;
            dgvGames.DataSource = sortedGames;
        }

        private void btnFindCheapest_Click(object sender, EventArgs e)
        {
            var games = manager.GetAllGames();
            if (games.Count > 0)
            {
                // Знаходимо першу гру з відсортованого за ціною списку
                var cheapestGame = games.OrderBy(g => g.Price).First();

                MessageBox.Show($"Найдешевша гра: {cheapestGame.Title}\nЦіна: {cheapestGame.Price} грн\nПлатформа: {cheapestGame.Platform}", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalculateDiscount_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count > 0)
            {
                // Беремо об'єкт гри прямо з вибраного рядка таблиці
                Game selectedGame = (Game)dgvGames.SelectedRows[0].DataBoundItem;

                // Магія поліморфізму:
                decimal finalPrice = selectedGame.CalculateCost();

                MessageBox.Show($"Гра: {selectedGame.Title}\nПочаткова ціна: {selectedGame.Price} грн\nЦіна до сплати (з урахуванням можливих знижок): {finalPrice} грн", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Виберіть гру зі списку для розрахунку.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
