namespace Kursach
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}

/*1 Добавить еще один интерфейс для доступа к объектам классов иерархии. При этом часть классов иерархии
 должны реализовывать только один из двух интерфесов, часть - другой и часть оба. Также
 доббавить класс, не входящий в иерархию, но также реализующий добавленный интерфейс.
2. Переделать меню- должны использоваться делегаты для выполнения методов разработанных классов.
3. Добавить графический пользовательский интерфейс в виде формы , нажатие кнопок на которой выполняет 
пункты ранее разработанного меню с отображение тещей информации об обхектах в текстовом поле
4 Добавить возможность сериализации и десерализации оъектов в файл.*/