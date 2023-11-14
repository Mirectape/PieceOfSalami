using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Cat
    {
        /// <summary>
        /// Создание экземпляра котика
        /// </summary>
        /// <param name="Nickname">Кличка</param>
        /// <param name="Breed">Порода</param>
        public Cat(string Nickname, string Breed)
        {
            this.Nickname = Nickname;
            this.breed = Breed;
        }
        public Cat() { }

        /// <summary>
        /// Id котика
        /// </summary>
        public int CatID { get; set; }

        /// <summary>
        /// Порода
        /// </summary>
        private string breed;

        /// <summary>
        /// Свойство, описываюее кличку
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Свойство, описываюее породу
        /// </summary>
        public string Breed { get { return this.breed; } set { this.breed = value; } }

        /// <summary>
        /// Метод, определеющий логику игры котика
        /// </summary>
        public void ToPlay() { Console.WriteLine($"{this.Nickname} играет..."); }

        /// <summary>
        /// Метод, определеющий логику сна котика
        /// </summary>
        public void ToSleep() { Console.WriteLine($"{this.Nickname} спит..."); }

        /// <summary>
        /// Метод, определеющий логику питания котика
        /// </summary>
        public void ToEat() { Console.WriteLine($"{this.Nickname} кушает..."); }

        /// <summary>
        /// Мяуканье котика
        /// </summary>
        public void ToMew() { Console.WriteLine($"Мяу!"); }
    }
}
