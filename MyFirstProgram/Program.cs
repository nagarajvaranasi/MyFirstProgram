using MyFirstProgram;

Student student = new Student("123456789");

//student.Name = "Pavan";
//student.Dob = "01-01-2000";
//student.Age = 30;
////student.PhoneNumber="1234567890";


//Console.WriteLine(student.Name);

//Console.WriteLine(student.Dob);

//Console.WriteLine(student.Age);

//student.ShowPhoneNumber();

Console.WriteLine("Enter Student Name");
student.Name = Console.ReadLine();

Console.WriteLine("Enter Student Dob");
student.Dob = Console.ReadLine();


Console.ReadLine();

Console.WriteLine("Do you want to enter correct DOB : Yes/No");

string result = Console.ReadLine();

if(result == "Yes")
{
    Console.WriteLine("Enter Student Dob again");
    student.Dob = Console.ReadLine();
    Console.WriteLine("Student Details");
    Console.WriteLine(student.Name);
    Console.WriteLine(student.Dob);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Student Details");
    Console.WriteLine(student.Name);
    Console.WriteLine(student.Dob);
    Console.ReadLine();

}



