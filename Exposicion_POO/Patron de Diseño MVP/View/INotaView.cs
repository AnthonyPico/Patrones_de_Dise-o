// Creamos una Interfaz que define métodos para obtener información y mostrar resultados
public interface INotaView
{
    // Métodos para obtener información del estudiante
    string GetNombre();         // Método para obtener el nombre
    string GetApellido();       // Método para obtener el apellido
    string GetAsignatura();     // Método para obtener la asignatura
    string GetCurso();          // Método para obtener el curso
    double GetNota1();          // Método para obtener la primera nota
    double GetNota2();          // Método para obtener la segunda nota
    
    // Método para mostrar los resultados
    void MostrarResultado(string nombre, string apellido, string asignatura, double promedio, bool aprobado);
    
}

