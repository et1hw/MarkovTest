using System;
using InspectorLib; // Подключаем библиотеку

namespace MarkovTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса FunctionInsp
            FunctionInsp insp = new FunctionInsp();

            // Тестируем метод GetInspector
            Console.WriteLine("Главный инспектор: " + insp.GetInspector());

            // Тестируем метод GetCarInspection
            Console.WriteLine("Название автоинспекции: " + insp.GetCarInspection());

            // Тестируем метод SetInspector
            Console.WriteLine("Попытка изменить главного инспектора на 'Иванов И.И.': " +
                              (insp.SetInspector("Иванов И.И.") ? "Успешно" : "Не удалось"));
            Console.WriteLine("Новый главный инспектор: " + insp.GetInspector());

            // Тестируем метод GenerateNumber
            string generatedNumber = insp.GenerateNumber(1234, 'a', 75);
            Console.WriteLine("Сгенерированный госномер: " + generatedNumber);

            // Тестируем метод GetWorker
            Console.WriteLine("Список сотрудников:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Тестируем метод AddWorker
            insp.AddWorker("Петров П.П.");
            Console.WriteLine("Список сотрудников после добавления:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
}

