using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace EntityFrameWorkDemo
{
    internal class WordContext : DbContext // Класс для описания набора данных 
    {
        public WordContext() : base("DbConnection") // в параметрах указаываем наименование соединения
        { }
        public DbSet<Word> Words {get; set; } // Набор сущностей (перебираемая коллекция), который мы описали
    }
}
