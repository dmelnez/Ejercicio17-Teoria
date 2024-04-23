using EjerciciosTeoria.Dtos;

namespace EjerciciosTeoria.Controladores
{

    class Program
    {

        public static void Main(string[] args)
        {
            // EJERCICIO 16

            List<EstudianteDtos> listaEstudiantes = new List<EstudianteDtos>();
            Dictionary<string, EstudianteDtos> estudiantes = new Dictionary<string, EstudianteDtos>();
            HashSet<EstudianteDtos> listaEstudiantesDuplicidad = new HashSet<EstudianteDtos>();


            do
            {
                Console.WriteLine("[0] -> Buscar Estudiante");
                Console.WriteLine("[1] -> Añadir Estudiante");
                int seleccion = Convert.ToInt32(Console.ReadLine());


                switch (seleccion)
                {
                    case 0:

                        Console.WriteLine("Nombre Estudiante: ");
                        string nombreEstudiante = Console.ReadLine();

                        foreach(var kvp in estudiantes)
                        {
                            if (kvp.Key == nombreEstudiante)
                            {
                                Console.WriteLine("Estudiante encontrado: " + nombreEstudiante);

                            }

                            else
                            {

                                Console.WriteLine("Usuario no encontrado");

                            }

                        }

                        break;
                    case 1:


                        EstudianteDtos estuadiante = new EstudianteDtos();

                        Console.WriteLine("Nombre: ");

                        estuadiante.Nombre = Console.ReadLine();

                        Console.WriteLine("Apellido: ");
                        estuadiante.Apellido = Console.ReadLine();

                        Console.WriteLine("Edad: ");
                        estuadiante.Edad = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Grado: ");
                        estuadiante.Grado = Console.ReadLine();



                        listaEstudiantes.Add(estuadiante);
                        listaEstudiantesDuplicidad.Add(estuadiante);

                        estudiantes.Add(estuadiante.Nombre, estuadiante);



                        break;

                    default:
                        Console.WriteLine("SELECION NO VALIDA");
                        break;

                }

            }

            while (true);



            foreach(var estudiante in listaEstudiantesDuplicidad)
            {

                Console.WriteLine("Nombre: " + estudiante.Nombre + " Apellidos: " + estudiante.Apellido + " Edad: " + estudiante.Edad + " Grado: " + estudiante.Grado);

            }





        }



    }

}

