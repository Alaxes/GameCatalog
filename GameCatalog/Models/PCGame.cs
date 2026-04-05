using System;

namespace GameCatalog.Models
{
    // Успадковуємося від класу Game
    public class PCGame : Game
    {
        // Конструктор. Використовуємо : base(...) щоб передати дані в базовий клас
        public PCGame(string genre, string title, string developer, string platform, decimal price)
            : base(genre, title, developer, platform, price)
        {
        }

        // ПЕРЕВИЗНАЧАЄМО віртуальний метод обчислення вартості
        public override decimal CalculateCost()
        {
            // Якщо ціна більше 1000, знижка 5% (тобто множимо на 0.95)
            if (Price > 1000m)
            {
                return Price * 0.95m;
            }

            return Price; // Інакше повна вартість
        }
    }
}