namespace ProjektNri_Nazwisko_NrAlbumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayProgramHeader();
            RunCalculatorMenu();

            DisplayProgramAuthorInfo();
        }

        static void DisplayProgramHeader()
        {
            Console.WriteLine(
                "\n\t\t\tPROGRAM KALKULATOR umożliwia obliczanie wartości wybranych wielkości matematycznych");
        }

        static void RunCalculatorMenu()
        {
            ConsoleKeyInfo selectedOption;

            do
            {
                DisplayMainMenu();
                selectedOption = Console.ReadKey();
                Console.WriteLine();

                switch (selectedOption.Key)
                {
                    case ConsoleKey.A:
                        RunLaboratoryCalculator();
                        break;
                    case ConsoleKey.B:
                        RunIndividualCalculator();
                        break;
                    case ConsoleKey.X:
                        break;
                    default:
                        DisplayInvalidOptionMessage();
                        break;
                }
            } while (selectedOption.Key != ConsoleKey.X);
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("\n\t\tMENU części głównej programu");
            Console.WriteLine("\t\tA. Kalkulator Laboratoryjny");
            Console.WriteLine("\t\tB. Kalkulator Indywidualny");
            Console.WriteLine("\t\tX. Zakończenie (wyjście z programu)");
            Console.Write("\n\t\tNaciśnij jeden z dozwolonych klawiszy (A, B, X) dla wybrania wymaganej funkcjonalności: ");
        }

        static void DisplayInvalidOptionMessage()
        {
            Console.WriteLine("\n\t\tERROR: nacisnąłeś niedozwolony znak!!!");
            Console.Write("\n\t\tNaciśnij dowolny klawisz dla kontynynuacji...");
            Console.ReadKey();
            Console.Clear();
        }

        static void DisplayProgramAuthorInfo()
        {
            Console.WriteLine("\n\n\t\tAutor programu: Taras Romaniuk, 71617");
            Console.WriteLine("\t\tDzisiejsza data: {0}", DateTime.Now);
            Console.Write("\n\t\tNaciśnij dowolny klawisz dla kontynynuacji...");
            Console.ReadKey();
        }

        static void RunLaboratoryCalculator()
        {
            ConsoleKeyInfo selectedFunction;

            do
            {
                DisplayLaboratoryMenu();
                selectedFunction = Console.ReadKey();
                Console.WriteLine();

                switch (selectedFunction.Key)
                {
                    case ConsoleKey.A:
                        CalculateAverage();
                        break;
                    case ConsoleKey.B:
                        CalculatePolynomial();
                        break;
                    case ConsoleKey.C:
                        ConvertingCharacterNumberIntoValue();
                        break;
                    case ConsoleKey.D:
                        CalculatingValueOfNewtonsSymbol();
                        break;
                    case ConsoleKey.X:
                        OutputFromLaboratoryCalculator();
                        break;
                    default:
                        DisplayInvalidOptionMessage();
                        break;
                }

                Console.Write("\n\t\tNaciśnij dowolny klawisz dla kontynuacji...");
                Console.ReadKey();
                Console.Clear();
            } while (selectedFunction.Key != ConsoleKey.X);
        }

        static void OutputFromLaboratoryCalculator()
        {
            /*
             * TODO: Передавати сюди масив з історією підрахунків і красивого вводити
             */
        }

        static void CalculatingValueOfNewtonsSymbol()
        {
            Console.WriteLine("\n\t\tWybrałeś funkcjonalność: D - Obliczenie wartości symbolu Newtona");
            /*
             * TODO: Дописати метод, використовуючи формулу 1N = 1kg (m/s/s).
             */
            Console.WriteLine("\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
        }
        
        static void ConvertingCharacterNumberIntoValue()
        {
            Console.WriteLine("\n\t\tWybrałeś funkcjonalność: C - Konwersja znakowego zapisu liczby na wartość");
            /*
             * TODO: Використовуй вбудовані методи для конвертації рядка в число як ми робили в Java
             */
            Console.WriteLine("\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
        }

        static void DisplayLaboratoryMenu()
        {
            Console.WriteLine("\n\t\tMENU Kalkulatora Laboratoryjnego");
            Console.WriteLine("\t\tA. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
            Console.WriteLine("\t\tB. Obliczenie wartości wielomianu n-tego stopnia");
            Console.WriteLine("\t\tC. Konwersja znakowego zapisu liczby na wartość");
            Console.WriteLine("\t\tD. Obliczenie wartości symbolu Newtona");
            Console.WriteLine("\t\tx. Wyjście z Kalkulatora Laboratoryjnego");
            Console.Write("\n\t\tNaciśnij dozwolony klawisz (A, B, C, D, X): ");
        }

        static void CalculateAverage()
        {
            Console.WriteLine("\n\t\tWybrałeś funkcjonalność: A - Obliczenie średniej arytmetycznej");
            Console.WriteLine("\n\t\tWrite nums: ");
            double[] numbers = ReadArrayFromConsole();
            double average = numbers.Average();
            Console.WriteLine("Average: " + average);
        }

        static void CalculatePolynomial()
        {
            Console.WriteLine("\n\t\tWybrałeś funkcjonalność: B - Obliczenie wartości wielomianu n-tego stopnia");
            Console.WriteLine("\n\t\tWrite coefficients: ");
            double[] coefficients = ReadArrayFromConsole();

            Console.WriteLine("Write polynomial argument: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = EvaluatePolynomial(coefficients, x);
            Console.WriteLine("Polynomial: " + result);
        }

        static void DisplayNotImplementedMessage()
        {
            Console.WriteLine("\n\t\tPRZEPRASZAM, ale jestem w trakcie realizacji (implementacji)");
        }

        static double EvaluatePolynomial(double[] coefficients, double x)
        {
            double result = coefficients[^1];

            for (int i = coefficients.Length - 2; i >= 0; i--)
            {
                result = result * x + coefficients[i];
            }

            return result;
        }

        static double[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
        }

        static void RunIndividualCalculator()
        {
            DisplayNotImplementedMessage();
        }
    }
}