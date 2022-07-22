// See https://aka.ms/new-console-template for more information
using SRP.AttendaceSystemWithoutSOLID;
using SRP.AttendanceSystemWithSOLID;

Console.WriteLine("Single Responsibility Principle");
Console.WriteLine("\r\n\r\n\r\n");


Console.WriteLine("Without SRP");
AttendanceSystemWithoutSOLID attendanceSystemWithoutSOLID = new AttendanceSystemWithoutSOLID();

attendanceSystemWithoutSOLID.AddAttendance();
attendanceSystemWithoutSOLID.SendAttendanceEmail();
attendanceSystemWithoutSOLID.LogInformation();

attendanceSystemWithoutSOLID.DeleteAttendance();
attendanceSystemWithoutSOLID.SendAttendanceEmail();
attendanceSystemWithoutSOLID.LogInformation();

Console.WriteLine("\r\n\r\n\r\n");

Console.WriteLine("With SRP");

AttendanceSystemWithSOLID attendanceSystemWithSOLID=new AttendanceSystemWithSOLID();

attendanceSystemWithSOLID.AddAttendance();
attendanceSystemWithSOLID.DeleteAttendance();

Console.ReadKey();