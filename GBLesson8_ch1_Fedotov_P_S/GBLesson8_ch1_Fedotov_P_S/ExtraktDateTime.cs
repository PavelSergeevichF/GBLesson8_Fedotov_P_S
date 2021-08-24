using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GBLesson8_ch1_Fedotov_P_S
{
    class ExtraktDateTime
    {
        
        public void getTyp()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            var tConstrt = typeof(DateTime).GetConstructors();
            Console.ReadLine();
            var tPu = typeof(DateTime).GetFields();
            var tNotPu = typeof(DateTime).GetFields (BindingFlags.NonPublic);
                Console.WriteLine("Приватные свойства "+tNotPu.Length);
            Console.WriteLine("Публичные свойства");
            foreach (var tp in tPu)
            {
                Console.WriteLine("Тип " + tp+" Имя "+tp.Name);
            }
            Console.WriteLine("Конструкторы свойства "+ tConstrt.Length);
            foreach (var m in tConstrt)
            {
                Console.Write(" " + m.Name + "(");
                // Вывести параметры.
                var pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            var tMet = typeof(DateTime).GetMethods();
            Console.WriteLine("Публичные Методы"+tMet.Length);
            foreach (var Met in tMet)
            {
                Console.Write(" " + Met.Name + "(");
                // Вывести параметры.
                var pi = Met.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            var tMetNotPub = typeof(DateTime).GetMethods(BindingFlags.NonPublic);
            Console.WriteLine("Приватные Методы" + tMetNotPub.Length);
        }
    }
}
