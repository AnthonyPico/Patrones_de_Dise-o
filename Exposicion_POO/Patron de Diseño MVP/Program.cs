class Program
{
    static void Main(string[] args)
    {
        var notaView = new NotaForm();
        var nuevaNota = new Nota();
        var presentador = new NotaPresenter(notaView, nuevaNota);
        presentador.ActualizarVista();

        double promedio = (nuevaNota.Nota1 + nuevaNota.Nota2) / 2.0;
        bool aprobado = promedio >= 7.0; // Considerando que 7 es la nota mínima para aprobar
        notaView.MostrarResultado(nuevaNota.Nombre, nuevaNota.Apellido, nuevaNota.Asignatura, promedio, aprobado);

        Console.ReadLine();
    }
}