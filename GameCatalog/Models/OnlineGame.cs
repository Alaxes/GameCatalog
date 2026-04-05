using System;

namespace GameCatalog.Models
{
    public class OnlineGame : Game
    {
        // Унікальне приватне поле для онлайн гри
        private int _numberOfPlayers;

        public int NumberOfPlayers
        {
            get { return _numberOfPlayers; }
            set { _numberOfPlayers = value; }
        }

        // Конструктор отримує додатковий параметр - кількість гравців
        public OnlineGame(string genre, string title, string developer, string platform, decimal price, int numberOfPlayers)
            : base(genre, title, developer, platform, price)
        {
            _numberOfPlayers = numberOfPlayers;
        }

        // ПЕРЕВИЗНАЧАЄМО віртуальний метод для онлайн ігор
        public override decimal CalculateCost()
        {
            // Якщо ціна ключа активації більше 500, знижка 10% (множимо на 0.90)
            if (Price > 500m)
            {
                return Price * 0.90m;
            }

            return Price;
        }
    }
}