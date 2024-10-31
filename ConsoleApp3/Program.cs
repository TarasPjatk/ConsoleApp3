using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNri_Nazwisko_NrAlbumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // декларація змінної, що ідентифікує натиснуту клавішу
            ConsoleKeyInfo wybranaFunkcjonalnosc;

            // Виведення метрики програми
            Console.WriteLine(
                "\n\t\t\tPROGRAM KALKULATOR umożliwia obliczanie wartości wybranych wielkości matematycznych");

            // Збереження багаторазового повторення виклику Калькуляторів
            do
            {
                // Виведення меню головної частини програми
                Console.WriteLine("\n\t\tMENU części głównej programu");

                // Виведення пунктів меню програми
                Console.WriteLine("\t\tA. Kalkulator Laboratoryjny");
                Console.WriteLine("\t\tB. Kalkulator Indywidualny");
                Console.WriteLine("\t\tX. Zakończenie (wyjście z programu)");

                // Підказка для користувача
                Console.Write(
                    "\n\t\tNaciśnij jeden z dozwolonych klawiszy (A, B, X) dla wybrania wymaganej funkcjonalności: ");

                // Зчитування натиснутої клавіші
                wybranaFunkcjonalnosc = Console.ReadKey();
                Console.WriteLine(); // Переход на нову лінію після натискання

                // Розпізнання вибраної функціональності
                if (wybranaFunkcjonalnosc.Key == ConsoleKey.A)
                {
                    // Виклик Калькулятора Лабораторного
                    KalkulatorLaboratoryjny();
                }
                else if (wybranaFunkcjonalnosc.Key == ConsoleKey.B)
                {
                    // Виклик Калькулятора Індивідуального
                    KalkulatorIndywidualny();
                }
                else if (wybranaFunkcjonalnosc.Key != ConsoleKey.X)
                {
                    // Сигналізація про помилку
                    Console.WriteLine("\n\t\tERROR: nacisnąłeś niedozwolony znak!!!");
                    Console.Write("\n\t\tNaciśnij dowolny klawisz dla kontynynuacji...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (wybranaFunkcjonalnosc.Key != ConsoleKey.X);

            // Виведення авторства програми
            Console.WriteLine("\n\n\t\tAutor programu: Taras Romaniuk, 71617");
            Console.WriteLine("\t\tDzisiejsza data: {0}", DateTime.Now);
            Console.Write("\n\t\tNaciśnij dowolny klawisz dla kontynynuacji...");
            Console.ReadKey();
        }

        #region Deklaracje metod z Kalkulatorami

        static void KalkulatorLaboratoryjny()
        {
            // Змінна для вибору функціональності
            ConsoleKeyInfo wybranaFunkcjonalnosc;

            do
            {
                // Виведення меню Калькулятора Лабораторного
                Console.WriteLine("\n\t\tMENU Kalkulatora Laboratoryjnego");
                Console.WriteLine("\t\tA. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\t\tB. Obliczenie wartości wielomianu n-tego stopnia");
                Console.WriteLine("\t\tC. Konwersja znakowego zapisu liczby na wartość");
                Console.WriteLine("\t\tD. Obliczenie wartości symbolu Newtona");
                Console.WriteLine("\t\tx. Wyjście z Kalkulatora Laboratoryjnego");

                Console.Write("\n\t\tNaciśnij dozwolony klawisz (A, B, C, D, X): ");

                wybranaFunkcjonalnosc = Console.ReadKey();
                Console.WriteLine();

                switch (wybranaFunkcjonalnosc.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\n\t\tWybrałeś funkcjonalność: A - Obliczenie średniej arytmetycznej");

                        Console.WriteLine("\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine(
                            "\n\t\tWybrałeś funkcjonalność: B - Obliczenie wartości wielomianu n-tego stopnia");
                        Console.WriteLine("\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine(
                            "\n\t\tWybrałeś funkcjonalność: C - Konwersja znakowego zapisu liczby na wartość");
                        Console.WriteLine("\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\n\t\tWybrałeś funkcjonalność: D - Obliczenie wartości symbolu Newtona");
                        Console.WriteLine("\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("\n\t\tWybrałeś funkcjonalność: X - Wyjście z Kalkulatora Laboratoryjnego");
                        break;
                    default:
                        Console.WriteLine("\n\t\tERROR: Nacisnąłeś niedozwolony znak");
                        break;
                }

                Console.Write("\n\t\tNaciśnij dowolny klawisz dla kontynuacji...");
                Console.ReadKey();
                Console.Clear();
            } while (wybranaFunkcjonalnosc.Key != ConsoleKey.X);
        }

        static double avg(double[] array) {
            if (array.Length == 0)
            {
                return 0;
            }
            
            double sum = 0;
            
            foreach(double variable in array)
            {
                sum += variable;
            }
            
            return sum / array.Length;
        }

        static void KalkulatorIndywidualny()
        {
            Console.WriteLine("\n\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
            Console.Write("\n\t\tNaciśnij dowolny klawisz dla kontynuacji...");
            Console.ReadKey();
        }

        #endregion
    }
}