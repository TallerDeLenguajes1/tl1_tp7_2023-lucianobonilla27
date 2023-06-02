// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;
Empleado richar = new();
richar.Apellido = "Robinson";
richar.Nombre = "Richar";
richar.FechaNac = new DateTime(2001,3,19);
richar.EstadoCivil = 's';
richar.Genero = 'm';
richar.FechaIng = new DateTime(2019,2,12);
richar.SueldoBasc = 150000.00;
richar.Cargo = Empleado.cargos.Ingeniero;
Console.WriteLine("Cargo de richar: " + richar.Cargo);
Console.WriteLine("Antiguedad de richar: " + richar.antiguedad() + " años");
Console.WriteLine("Edad de richar: " + richar.edad() + " años");
Console.WriteLine("Richar se jubila en : " + richar.edad()+ " años");
Console.WriteLine("Richar cobra $" + richar.salario() );






