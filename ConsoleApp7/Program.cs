

ConsoleKeyInfo key;
do
{
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.RightArrow)
    {
        strelka();
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        strelka();
    }

} while (key.Key != ConsoleKey.Escape);
static void strelka()
{
    int a = 1;
    int b = 10;
    int c = 2023;


    do
    {
        int pos;
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.RightArrow)
        {
            a = a + 1;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            if (a == 4)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. зайти в тарков");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. зайти в доту");

            }
            if (a == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. зайти в тарков");

            }
            if (a == 7)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. пойти на пары");

            }
        }
        if (key.Key == ConsoleKey.LeftArrow)
        {
            a = a - 1;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            if (a == 4)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. зайти в тарков");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. зайти в доту");
            }
            if (a == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. зайти в тарков");

            }
        }
        if (key.Key == ConsoleKey.DownArrow)
        {
            if (a == 4)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. зайти в тарков");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. зайти в доту");
                pos = 2;
            }

        }
        if (key.Key == ConsoleKey.UpArrow)
        {
            if (a == 4)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. зайти в тарков");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. зайти в доту");

            }
        }
        if (a == 4 && key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("зайти в тарков");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Описание: пойти на завод и слить весь лут");
            Console.WriteLine("дата " + a + "." + b + "." + c + " " + "0:00:00");
        }
        if (a == 4 && key.Key == ConsoleKey.Backspace)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("1. зайти в тарков");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("2. зайти в доту");

        }

        if (a == 1 && key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("зайти в корабли");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Описание: выполнить задачи на SCHILL");
            Console.WriteLine("дата " + a + "." + b + "." + c + " " + "0:00:00");
        }
        if (a == 1 && key.Key == ConsoleKey.Backspace)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("1. зайти в тарков");

        }
        if (a == 7 && key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("пойти на пары");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Описание: отсидеть с первой по четвёртую пару");
            Console.WriteLine("дата " + a + "." + b + "." + c + " " + "8:30:00");
        }
        if (a == 7 && key.Key == ConsoleKey.Backspace)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выбрана дата " + a + "." + b + "." + c);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("->");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("1. пойти на пары");

        }
        if (key.Key == ConsoleKey.Escape)
        {

            break;
        }
    }
    while (true);
}

