// Creamos una Clase que implementara la interfaz INotaView

public class NotaForm : INotaView
{
    // Métodos para obtener información del estudiante
    // Método para obtener el nombre del estudiante
    public string GetNombre()
    {
        Console.Write("Ingrese nombres del estudiante: ");
        return Console.ReadLine();
    }

    // Método para obtener el apellido del estudiante
    public string GetApellido()
    {
        Console.Write("Ingrese apellidos del estudiante: ");
        return Console.ReadLine();
    }

    // Método para obtener la asignatura correspondiente
    public string GetAsignatura()
    {
        Console.Write("Ingrese la asignatura correspondiente: ");
        return Console.ReadLine();
    }

    // Método para obtener el curso del estudiante
    public string GetCurso()
    {
        Console.Write("Ingrese el curso: ");
        return Console.ReadLine();
    }

    // Método para obtener la nota del Primer Parcial con validación
    public double GetNota1()
    {
        double nota1;
        do
        {
            Console.Write("Ingrese nota del Primer Parcial (entre 0 y 10): ");
            nota1 = Convert.ToDouble(Console.ReadLine());
        } while (nota1 < 0 || nota1 > 10);  // Validación para asegurarse de que la nota esté en el rango correcto
        return nota1;
    }

    // Método para obtener la nota del Segundo Parcial con validación
    public double GetNota2()
    {
        double nota2;
        do
        {
            Console.Write("Ingrese nota del Segundo Parcial (entre 0 y 10): ");
            nota2 = Convert.ToDouble(Console.ReadLine());
        } while (nota2 < 0 || nota2 > 10);  // Validación para asegurarse de que la nota esté en el rango correcto
        return nota2;
    }

    // Método para mostrar los resultados
    public void MostrarResultado(string nombre, string apellido, string asignatura, double promedio, bool aprobado)
    {
        string estado = aprobado ? "Aprobado" : "Reprobado";
        Console.WriteLine($"Resultados: {nombre} {apellido}, {asignatura}: {promedio} ({estado})");
    }
}