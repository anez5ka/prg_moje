using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Program
    {
        class Human // private (nespecifikovano = private, pristupno jen ve tride samotne)
                    // protected (pristupno i ve tridach co od te vychozi "dedi")
                    // public (pristupno vzdy a vsude)
        {
            public int age;
            public int height;
            public int weight;
            public string name;
            public string skincolor;
            public Human partner;

            public void IntroduceHuman()
            {
                Console.WriteLine($"Jmenuji se {name}, je mi {age} let, merim {height} cm a vazim {weight} kg.");
            }
            public Human()
            {

            }
            public Human(string name)
            {
                this.name = name;
            }
            public Human(int age, int height, int weight, string name) //konstruktor
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.name = name;
            }

            //static 
            //nonstatic vazana na konretni instanci, napr bmi
            public static Human MakeChild(Human human1, Human human2)
            {
                if (human1.partner == human2 && human2.partner == human1)
                {
                    Human child = new Human();
                    child.age = 0;
                    child.height = (human1.height + human2.height)/2;
                    child.weight= (human1.weight + human2.weight)/2;
                    child.name = human1.name + " " + human2.name;
                    return child;
                }
                else
                {
                    Console.WriteLine("tady nekdo zahyba");
                    return new Human("Bastard");
                }
            }
            public Human MakeChildWith(Human human2)
            {
                if (partner == human2) 
                {
                    Human child = new Human();
                    child.age = 0;
                    child.height = (height + human2.height) / 2;
                    child.weight = (weight + human2.weight) / 2;
                    child.name = name + " Anne " + human2.name;
                    return child;
                }
                else
                {
                    Console.WriteLine("tady nekdo zahyba");
                    return new Human("Bastard");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            Human human1 = new Human();
            human1.age = 32;
            human1.height = 160;
            human1.weight = 90;
            human1.name = "gERTrUda";
            human1.skincolor = ("green");
            human1.IntroduceHuman();

            Human human2 = new Human();
            human2.age = 40;
            human2.height = 210;
            human2.weight = 100;
            human2.name = "BOB";
            human2.skincolor = ("pink");
            human2.IntroduceHuman();

            human1.partner= human2;
            human2.partner= human1;

            Human human3 = new Human(30, 170, 40, "bOhdANa");
            human3.IntroduceHuman();

            Human newChild = Human.MakeChild(human1, human2);
            newChild.IntroduceHuman();

            Human newerChild = human1.MakeChildWith(human2);
            newerChild.IntroduceHuman();

            Console.ReadKey();

        }
    }
}
