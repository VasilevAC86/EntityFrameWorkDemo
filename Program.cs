using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace EntityFrameWorkDemo // Позволяет работать с БД без SQL, структура БД по коду
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(WordContext context = new WordContext()) // В using мы можем сохранять что-либо в БД
            {
                // Пара слов
                Word word001 = new Word()
                {
                    Name = "Молоток",
                    Description = "Ручной инструмент для общения с гвоздями"
                };
                Word word002 = new Word()
                {
                    Name = "Отвёртка",
                    Description = "Ручной инструмент для общения с шурупами с винтами"
                };
                // Добавление в БД (поле Id заполняется автоматически)
                /*context.Words.Add(word001);
                context.Words.Add(word002);
                context.SaveChanges(); // Сохраняем изменения*/
                Console.WriteLine($"В БД Dictionary добавлены слова {word001.Name} и {word002.Name}.");
                var _words = context.Words; // Переменная для сохранения из БД
                foreach (var word in _words)
                {
                    Console.WriteLine(word.Id + "." + word.Name + "\t" + word.Description);
                }
                Console.ReadLine(); // Чтобы консоль в .exe-файле ждала реакции пользователя
            }
        }
    }
}
