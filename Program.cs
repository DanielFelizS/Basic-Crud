
namespace Arrays
{  
        class CRUD
        {
        static void Main(string[] args)
        {
            int id, eleccion;
            string nombre, apellido, sexo;
            List<Persona> datos = new List<Persona>(); 

            while (true)
            {
                Console.WriteLine("##### CRUD con arreglos ######");
                Console.WriteLine("Escoja la accion que quiere hacer");
                Console.WriteLine("1. Agregar datos");
                Console.WriteLine("2. Editar datos");
                Console.WriteLine("3. Eliminar datos");
                Console.WriteLine("4. Consultar datos");
                Console.WriteLine("5. Obtener datos por Id");
                Console.WriteLine("6. Obtener número especifico de datos");
                Console.WriteLine("7. Buscar datos");
                Console.WriteLine("8. Salir del programa");

                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // Add Data
                if (eleccion == 1)
                {
                    try
                    {
                        Console.WriteLine("Ingresa el id de la persona");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingresa el nombre de la persona");
                        nombre = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Ingresa el apellido de la persona");
                        apellido = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Ingresa el sexo de la persona (M o F)");
                        sexo = Convert.ToString(Console.ReadLine());

                        if (id >= 1) datos.Add(new Persona(id, nombre, apellido, sexo));
                        else if (sexo != "M" || sexo != "F") Console.WriteLine("Ingrese solo el primer carácter del sexo");
                        else Console.WriteLine("Ingrese un id correcto");
                        // Console.Clear();

                        Console.WriteLine("Id  Nombre  Apellido  Sexo ");
                        foreach (Persona persona in datos)
                        {
                            Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Los datos no se pudieron agregar {ex.ToString()}");
                    }
                }
                
                // Edit Data
                else if (eleccion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el id de la persona que deseas editar");
                    id = Convert.ToInt32(Console.ReadLine());

                    // Buscar la persona con el ID especificado
                    Persona personaEditar = datos.Find(persona => persona.ID == id);

                    if (personaEditar != null)
                    {
                        Console.WriteLine($"Seleccionaste a la persona con ID {personaEditar.ID}:");
                        Console.WriteLine("1. Editar nombre");
                        Console.WriteLine("2. Editar apellido");
                        Console.WriteLine("3. Editar sexo");
                        Console.WriteLine("4. Editar Todos los datos");
                        Console.WriteLine("5. Cancelar");

                        int opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingresa el nuevo nombre de la persona:");
                                nombre = Convert.ToString(Console.ReadLine());
                                personaEditar.Nombre = nombre;
                                Console.WriteLine("Nombre actualizado exitosamente.");
                                break;

                            case 2:
                                Console.WriteLine("Ingresa el nuevo apellido de la persona:");
                                apellido = Convert.ToString(Console.ReadLine());
                                personaEditar.Apellido = apellido;
                                Console.WriteLine("Apellido actualizado exitosamente.");
                                break;

                            case 3:
                                Console.WriteLine("Ingresa el nuevo sexo de la persona (M o F):");
                                sexo = Convert.ToString(Console.ReadLine());
                                personaEditar.Sexo = sexo;
                                Console.WriteLine("Sexo actualizado exitosamente.");
                                break;

                            case 4:
                                Console.WriteLine("Ingresa el nuevo nombre de la persona");
                                nombre = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingresa el nuevo apellido de la persona");
                                apellido = Convert.ToString(Console.ReadLine());

                                Console.WriteLine("Ingresa el nuevo sexo de la persona (M o F)");
                                sexo = Convert.ToString(Console.ReadLine());

                                // Actualizar los atributos de la persona
                                personaEditar.Nombre = nombre;
                                personaEditar.Apellido = apellido;
                                personaEditar.Sexo = sexo;
                                break;

                            case 5:
                                Console.WriteLine("Edición cancelada.");
                                break;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }

                        // Mostrar la lista después de la edición
                        Console.WriteLine("Id  Nombre  Apellido  Sexo ");
                        foreach (Persona persona in datos)
                        {
                            Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ninguna persona con el ID especificado.");
                    }
                    // break;
                }
                
                // Delete Data
                else if (eleccion == 3)
                {
                    // Console.Clear();
                    Console.WriteLine("Eliminar todos los datos de una persona");
                    Console.WriteLine("Ingrese el id de la persona");
                    id = Convert.ToInt32(Console.ReadLine());

                    // Eliminar la persona con el ID especificado
                    datos.RemoveAll(persona => persona.ID == id);
                    // Math.abs();
                    foreach (Persona persona in datos)
                    {
                        Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                    }
                }
                
                // Get All Data
                else if (eleccion == 4)
                {
                    // Console.Clear();
                    Console.WriteLine("Id  Nombre  Apellido  Sexo ");
                    foreach (Persona persona in datos)
                    {
                        Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                    }
                }
                
                // Get Data by Id
                else if (eleccion == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el id de la persona que deseas ver");
                    id = Convert.ToInt32(Console.ReadLine());

                    var personaSeleccionada = datos.FirstOrDefault(persona => persona.ID == id);

                    if (personaSeleccionada != null)
                    {
                        // Si la persona existe, la mostramos
                        Console.WriteLine("Id  Nombre  Apellido  Sexo");
                        Console.WriteLine($"{personaSeleccionada.ID}   {personaSeleccionada.Nombre}   {personaSeleccionada.Apellido}   {personaSeleccionada.Sexo}");
                    }

                }
               
                // Get Data by the specific number
                else if(eleccion == 6)
                {
                    Console.WriteLine("Ingresa la cantidad de personas que quieres obtener");

                    if (!int.TryParse(Console.ReadLine(), out int getData) || getData <= 0)
                    {
                        Console.WriteLine("Por favor, ingresa un número válido mayor a 0.");
                        return;
                    }

                    // Validar que no exceda el tamaño de la lista
                    if (getData > datos.Count)
                    {
                        Console.WriteLine($"Solo hay {datos.Count} personas disponibles. Mostrando todas las personas:");
                        getData = datos.Count; 
                    }

                    Console.WriteLine("Id  Nombre  Apellido  Sexo ");

                    for (int i = 0; i < getData; i++)
                    {
                        var persona = datos[i];
                        Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");                         
                    }
                }
                
                // Search data
                else if(eleccion == 7)
                {
                    Console.WriteLine("Ingrese el valor que quiere buscar:");
                    string search = Console.ReadLine();

                    if (!string.IsNullOrEmpty(search))
                    {
                        // Filtrar los datos que coincidan con el criterio de búsqueda
                        var resultados = datos.Where(d =>
                            (d.Nombre != null && d.Nombre.Contains(search, StringComparison.OrdinalIgnoreCase)) ||
                            (d.Apellido != null && d.Apellido.Contains(search, StringComparison.OrdinalIgnoreCase)) ||
                            (d.Sexo != null && d.Sexo.Contains(search, StringComparison.OrdinalIgnoreCase))
                        );

                        if (resultados.Any())
                        {
                            Console.WriteLine("Resultados encontrados:");
                            foreach (var persona in resultados)
                            {
                                Console.WriteLine($"{persona.ID}   {persona.Nombre}   {persona.Apellido}   {persona.Sexo}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron resultados.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un valor válido para buscar.");
                    }
                }

                // to exit program
                else if (eleccion == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Has salido del programa");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Escoja una opcion correcta");
                }
            }
        }
    }
}