namespace Assignment_5_enum___struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: WeekDays Enum
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Question 2: Season Enum
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();
            //Season season;

            //if (Enum.TryParse(input, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}
            #endregion

            #region Question 3: Permissions Enum
            //Permissions userPermissions = Permissions.None;

            //// Add permissions
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //// Check if specific permission is present
            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission is present.");
            //}

            //if ((userPermissions & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine("Execute permission is present.");
            //}
            //else
            //{
            //    Console.WriteLine("Execute permission is not present.");
            //}

            //// Remove permission
            //userPermissions &= ~Permissions.Write;

            //// Check if specific permission is present
            //if ((userPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is present.");
            //}
            //else
            //{
            //    Console.WriteLine("Write permission is not present.");
            //}
            #endregion

            #region Question 4: Colors Enum
            //Console.WriteLine("Enter a color (Red, Green, Blue, Yellow, Black, White): ");
            //string colorInput = Console.ReadLine();
            //Colors color;

            //if (Enum.TryParse(colorInput, true, out color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered.");
            //}
            #endregion
        }
    }

    #region Enums

    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    public enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White
    }

    #endregion
}
