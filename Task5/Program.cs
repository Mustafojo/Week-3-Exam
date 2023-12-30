var student = new Student("Mustafo","Qalacha","C#",16,1000);

System.Console.WriteLine("Student: ");
System.Console.WriteLine("Name: " + student.getName());
System.Console.WriteLine("Address: " + student.getAddress()); 
System.Console.WriteLine("Program: " + student.getProgram());
System.Console.WriteLine("AGE: " + student.getYear());
System.Console.WriteLine("Fee: " + student.getFee());
System.Console.WriteLine("----------------------------------");

var staff = new Staff("Staff","UlSteff","Cambrij",100);

System.Console.WriteLine("Staff: ");
System.Console.WriteLine("Name: " + staff.getName());
System.Console.WriteLine("Address: " + staff.getAddress()); 
System.Console.WriteLine("Program: " + staff.getSchool());
System.Console.WriteLine("AGE: " + staff.getPay());
System.Console.WriteLine("----------------------------------");
