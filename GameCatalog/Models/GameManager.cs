using System;
using System.Collections.Generic;
using System.Linq;       //приколюха ка дозволяє шукати і фільтрувати списки буквально одним рядком коду, замість того щоб писати довгі цикли

namespace GameCatalog.Models // Або просто GameCatalog, залежить від того, де ти створив файл
{
    public class GameManager
    {
        // Приватний список ігор
        private List<Game> games;

        // Конструктор: ініціалізуємо порожній список при запуску
        public GameManager()
        {
            games = new List<Game>();
        }

        // Метод додавання гри
        public Game AddGame(Game game)
        {
            games.Add(game);
            return game; // Повертаємо додану гру, як ти й просив
        }

        // Метод видалення гри за назвою
        public void DeleteGame(string title)
        {
            // Шукаємо першу гру, назва якої збігається з переданою (ігноруючи великі/малі літери)
            var gameToRemove = games.FirstOrDefault(g => g.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            // Якщо таку гру знайдено — видаляємо
            if (gameToRemove != null)
            {
                games.Remove(gameToRemove);
            }
        }

        // Метод фільтрації по жанру
        public List<Game> FilterByGenre(string genre)
        {
            // Вибираємо всі ігри заданого жанру і конвертуємо результат назад у List
            return games.Where(g => g.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Додатковий метод (тобі він 100% знадобиться для виводу всіх ігор на екран)
        public List<Game> GetAllGames()
        {
            return games;
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var game in games)
                {
                    // Перевіряємо тип гри, щоб записати правильну ознаку та поля
                    if (game is PCGame)
                    {
                        // Формат: Ознака | Жанр | Назва | Розробник | Платформа | Ціна
                        writer.WriteLine($"PC|{game.Genre}|{game.Title}|{game.Developer}|{game.Platform}|{game.Price}");
                    }
                    else if (game is OnlineGame onlineGame)
                    {
                        // Формат: Ознака | Жанр | Назва | Розробник | Платформа | Ціна | Кількість гравців
                        writer.WriteLine($"Online|{onlineGame.Genre}|{onlineGame.Title}|{onlineGame.Developer}|{onlineGame.Platform}|{onlineGame.Price}|{onlineGame.NumberOfPlayers}");
                    }
                }
            }
        }

        // Завантаження списку ігор з текстового файлу
        public void LoadFromFile(string filePath)
        {
            // Якщо файлу ще не існує (наприклад, при першому запуску), просто виходимо
            if (!File.Exists(filePath)) return;

            games.Clear(); // Очищаємо поточний список перед завантаженням нових даних

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                // Читаємо файл по одному рядку до самого кінця
                while ((line = reader.ReadLine()) != null)
                {
                    // Розбиваємо рядок на частини по символу '|'
                    string[] parts = line.Split('|');

                    if (parts.Length < 6) continue; // Захист: пропускаємо пошкоджені рядки

                    // Зчитуємо базові поля
                    string type = parts[0];
                    string genre = parts[1];
                    string title = parts[2];
                    string dev = parts[3];
                    string platform = parts[4];
                    decimal price = decimal.Parse(parts[5]);

                    // Відновлюємо об'єкти залежно від їхнього типу
                    if (type == "PC" && parts.Length >= 6)
                    {
                        games.Add(new PCGame(genre, title, dev, platform, price));
                    }
                    else if (type == "Online" && parts.Length >= 7)
                    {
                        int players = int.Parse(parts[6]);
                        games.Add(new OnlineGame(genre, title, dev, platform, price, players));
                    }
                }
            }
}
    }
}