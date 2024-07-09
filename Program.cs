namespace Assignment_5_enum___struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    #region Question 1 - Boxing & Unboxing
        //    BoxingAndUnboxingExample();
        //    #endregion

        //    #region Question 2 - Nullable ValueTypes
        //    NullableValueTypesExample();
        //    #endregion

        //    #region Question 3 - Nullable ReferenceType
        //    NullableReferenceTypeExample();
        //    #endregion

        //    #region Question 4 - Null Propagation Operator
        //    NullPropagationOperatorExample();
        //    #endregion

        //    #region Question 5 - Exception Handling And Protective Code
        //    ExceptionHandlingExample();
        //    #endregion

        //    #region Question 6 - Access Modifiers
        //    AccessModifiersExample();
        //    #endregion

        //    #region Question 7 - Enum
        //    EnumExample();
        //    #endregion
        //}

        //#region Question 1 - Boxing & Unboxing
        //static void BoxingAndUnboxingExample()
        //{
        //    int num = 123;          // Value type
        //    object obj = num;       // Boxing
        //    int unboxedNum = (int)obj; // Unboxing

        //    Console.WriteLine("Boxed value: " + obj);
        //    Console.WriteLine("Unboxed value: " + unboxedNum);
        //}
        //#endregion

        //#region Question 2 - Nullable ValueTypes
        //static void NullableValueTypesExample()
        //{
        //    int? num = null;
        //    if (num.HasValue)
        //    {
        //        Console.WriteLine("Value: " + num.Value);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Value is null");
        //    }
        //}
        //#endregion

        //#region Question 3 - Nullable ReferenceType
        //static void NullableReferenceTypeExample()
        //{
        //    string? name = null;
        //    if (name != null)
        //    {
        //        Console.WriteLine("Name: " + name);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Name is null");
        //    }
        //}
        //#endregion

        //#region Question 4 - Null Propagation Operator
        //static void NullPropagationOperatorExample()
        //{
        //    Person? person = null;
        //    Console.WriteLine(person?.Name ?? "Person is null");
        //}

        //class Person
        //{
        //    public string? Name { get; set; }
        //}
        //#endregion

        //#region Question 5 - Exception Handling And Protective Code
        //static void ExceptionHandlingExample()
        //{
        //    try
        //    {
        //        int[] numbers = { 1, 2, 3 };
        //        Console.WriteLine(numbers[3]);
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        Console.WriteLine("Index out of range: " + ex.Message);
        //    }
        //}
        //#endregion

        //#region Question 6 - Access Modifiers
        //static void AccessModifiersExample()
        //{
        //    Person person = new Person("John");
        //    person.DisplayName();
        //    // Console.WriteLine(person.name); // Error: 'Person.name' is inaccessible due to its protection level
        //}

        //class Person
        //{
        //    private string name; // private field

        //    public Person(string name)
        //    {
        //        this.name = name; // accessible within the class
        //    }

        //    public void DisplayName()
        //    {
        //        Console.WriteLine("Name: " + name); // accessible within the class
        //    }
        //}
        //#endregion

        //#region Question 7 - Enum
        //static void EnumExample()
        //{
        //    Days today = Days.Wednesday;
        //    Console.WriteLine("Today is: " + today);
        //}

        //enum Days
        //{
        //    Sunday,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //}
        //#endregion
    }
}
