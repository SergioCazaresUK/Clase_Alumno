using Clase_Alumno;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Sergio";
alumno1.ApellidoPaterno = "Cazares";
alumno1.Matricula = "634";
alumno1.FechaNacimiento = new DateTime(2003 ,10 ,02);


Alumno alumno2 = new Alumno();
alumno2.Nombres = "Ramon";
alumno2.ApellidoPaterno = "Arambula";
alumno2.Matricula = "124";
alumno2.FechaNacimiento = new DateTime(1999, 08, 27);

lista.Add(alumno1);
lista.Add(alumno2);

foreach (Alumno alumnoEnLista in lista)
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto
        + " Matricula: "
        + alumnoEnLista.Matricula
        + " fecha nacimiento: "
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}
