// Clase que sirve como presentador
public class NotaPresenter
{
    private readonly INotaView _view;
    private readonly Nota _model;

    // Constructor que recibe instancias de la vista y el modelo
    public NotaPresenter(INotaView view, Nota model)
    {
        _view = view;
        _model = model;
    }

    // Método para actualizar la vista con la información del modelo
    public void ActualizarVista()
    {
        // Obtener información del estudiante desde la vista y actualizar el modelo
        _model.Nombre = _view.GetNombre();
        _model.Apellido = _view.GetApellido();
        _model.Asignatura = _view.GetAsignatura();
        _model.Curso = _view.GetCurso();
        _model.Nota1 = _view.GetNota1();
        _model.Nota2 = _view.GetNota2();
    }
}
