namespace EspacioEmpleado;
public class Empleado
{
    public enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialistas,
        investigador
    }
    private string nombre;
    public string Nombre { get => nombre; set => nombre = value; }

    private string apellido;
    public string Apellido { get => apellido; set => apellido = value; }

    private DateTime fechaNac;
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

    private char estadoCivil;
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

    private char genero;
    public char Genero { get => genero; set => genero = value; }

    private DateTime fechaIng;
    public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }

    private double sueldoBasc;
    public double SueldoBasc { get => sueldoBasc; set => sueldoBasc = value; }

    cargos cargo;
    public cargos Cargo { get => cargo; set => cargo = value; }

    public int antiguedad()
    {
        DateTime fechaActual = DateTime.Now;
        int antiguedad = fechaActual.Year - fechaIng.Year;
        return antiguedad;

    }
    public int edad(){
        DateTime hoy = DateTime.Now;
        int edad = hoy.Year - fechaNac.Year;
        return edad;

    }

    public int jubilacion(){
        if (genero == 'm')
        {
            if (antiguedad() > 65)
            {
                return 0;
            }else
            {
                return 65 - antiguedad();
            }
        }
        if (genero == 'f')
        {
            if (antiguedad() > 60)
            {
                return 0;
            }else
            {
                return 60 - antiguedad();
            }
        }
        return 999;
    }

    public double salario(){
        double salario;
        double adicional;
        if (antiguedad() < 20)
        {
            adicional = (antiguedad()*0.01) * sueldoBasc;
        }else
        {
            adicional = 0.25 * sueldoBasc;
        }
        if (cargo == cargos.Ingeniero || cargo == cargos.Especialistas)
        {
            adicional*= 1.50;
        }
        if (estadoCivil == 'c')
        {
            adicional += 15000;
        }
       salario = sueldoBasc + adicional;
       return salario;
    }

}