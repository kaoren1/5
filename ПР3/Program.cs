using System;
using System.ComponentModel.Design;

namespace ПР3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Для управления используются клавиши: A S E D R F T G H U J I");
            Console.WriteLine("Октавы: F6 - шестая, F7 - седьмая, F8 - восьмая, Escape - выход");
            ConsoleKey s = ConsoleKey.F6;
            int i = 0;
            while (i == 0)
            {
                ConsoleKeyInfo a = Console.ReadKey(true);
                switch (a.Key)
                {
                    case ConsoleKey.A:
                        Sound(0, s);
                        break;
                    case ConsoleKey.S:
                        Sound(1, s);
                        break;
                    case ConsoleKey.E:
                        Sound(2, s);
                        break;
                    case ConsoleKey.D:
                        Sound(3, s);
                        break;
                    case ConsoleKey.R:
                        Sound(4, s);
                        break;
                    case ConsoleKey.F:
                        Sound(5, s);
                        break;
                    case ConsoleKey.T:
                        Sound(6, s);
                        break;
                    case ConsoleKey.G:
                        Sound(7, s);
                        break;
                    case ConsoleKey.H:
                        Sound(8, s);
                        break;
                    case ConsoleKey.U:
                        Sound(9, s);
                        break;
                    case ConsoleKey.J:
                        Sound(10, s);
                        break;
                    case ConsoleKey.I:
                        Sound(11, s);
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Завершение программы");
                        i = 1;
                        break;
                }
            }
        }
        static int[] ViborOctav(ConsoleKey key)
        {   
            int[] octave = new int[12];
            if (key == ConsoleKey.F6)
            {
                octave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 }; //шестая
            }
            else if (key == ConsoleKey.F7)
            {
                octave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 }; //седьмая
            }
            else if (key == ConsoleKey.F8)
            {
                octave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 }; //восьмая
            }
            return octave;
        }
        static void Sound(int a, ConsoleKey c)
        {
            int[] k = ViborOctav(c);
            Console.Beep(k[a], 1000);
        }
    }
}