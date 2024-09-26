using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo
{
    internal class Word
    {
        // Поля будущей таблицы
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
