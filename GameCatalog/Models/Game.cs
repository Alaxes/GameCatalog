using System;

namespace GameCatalog.Models
{
    // Базовий клас для всіх ігор
    public class Game
    {
        // Приватні поля
        private string _genre;
        private string _title;
        private string _developer;
        private string _platform;
        private decimal _price;

        // Конструктор базового класу
        public Game(string genre, string title, string developer, string platform, decimal price)
        {
            _genre = genre;
            _title = title;
            _developer = developer;
            _platform = platform;
            _price = price;
        }

        // Властивості для доступу
        public string Genre { get { return _genre; } set { _genre = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Developer { get { return _developer; } set { _developer = value; } }
        public string Platform { get { return _platform; } set { _platform = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }

        // ВІРТУАЛЬНИЙ МЕТОД обчислення вартості
        public virtual decimal CalculateCost()
        {
            return _price; // Базова вартість без знижок
        }
    }
}