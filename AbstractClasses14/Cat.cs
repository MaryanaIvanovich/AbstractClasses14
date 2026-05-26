using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses14
{
    class Cat : Animal
    {
        public string breed { get; set; }
        
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat(string name)
            : base(name)
        {
        }
        public Cat(string name, string breed)
            : base(name)
        {
            this.breed = breed;
        }
        public void GetBreed() => Console.WriteLine(this.breed);
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
