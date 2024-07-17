using System;
using System.Collections;

namespace trabajoFinal
{
    class todosLugaresOcupadosException : Exception { }
    class lugarDeseadoOcupadoException : Exception { }
    class Program
    {
        static void Main(string[] args)
        {
            int maquinasDisponible = 20;
            Ciber theCheapest = new Ciber("TheCheapest", 0, 0, 60);
            for(int i=1; i==20; i++)
            {
                Maquina motherMachine = new Maquina(i, null, 0);
                theCheapest.agregaMaquina(motherMachine);
            }           
            string saliOno = "si";

            while (saliOno != "")
            {
                Console.WriteLine("1_Para cargar un usuario");
                Console.WriteLine("2_Cerrar el uso de maquina generando ticket de cobro, modificar la recaudación de la máquina");
                Console.WriteLine("3_Imprimir en detalle el monto recaudado por cada máquina");
                Console.WriteLine("4_Ver el total recaudado por el Ciber");
                Console.WriteLine("5_Agregar usuario a lista de clientes");
                Console.WriteLine("6_Ver lista de clientes de la lista de clientes");
                Console.WriteLine("7_Eliminar un usuario");
                Console.WriteLine("8_listado de maquinas ocupadas");
                Console.WriteLine("Elija una opcion");

                int opcion = 0;
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    while (opcion > 8 || opcion < 1)
                    {
                        Console.WriteLine("Opcion no valida, elija una opcion entre 1 y 8");
                        opcion = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formato introducido no valido");
                }

                switch (opcion)
                {
                    case 1:

                        try
                        {
                            if (maquinasDisponible == 0)
                            {
                                throw new todosLugaresOcupadosException();
                            }
                            //bool ocupacion = false;
                            Console.WriteLine("Ingrese la hora de inicio en formato hh:mm");
                            DateTime starTime = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la hora de finalizacion en formato hh:mm");
                            DateTime endTime = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el numero de asiento que desea , el numero mas alto de asiento es el 20 ");
                            int chairNum = int.Parse(Console.ReadLine());
                            var horaInicio = starTime.Hour;
                            var horaFinal = endTime.Hour;
                            double horaTotal = horaFinal - horaInicio;

                            while (chairNum > 20 || chairNum < 1)
                            {
                                Console.WriteLine("Opcion no valida intente denuevo");
                                opcion = int.Parse(Console.ReadLine());
                            }

                            foreach (Maquina i in theCheapest.Maquinas)
                            {
                                if (i.NumeroMaquina == chairNum && i.User != null)
                                {
                                    //ocupacion = true;
                                    throw new lugarDeseadoOcupadoException();
                                }
                                else if (i.NumeroMaquina == chairNum && i.User == null && horaInicio >= 6 && horaFinal <= 9)
                                {
                                    Console.WriteLine("Ingrese el nombre del usuario");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Ingrese su apellido");
                                    string lastName = Console.ReadLine();
                                    double montoApagar = horaTotal * theCheapest.PrecioHora;
                                    double montoARestar = montoApagar * 0.2;
                                    double precioConDescuento = montoApagar - montoARestar;
                                    Console.WriteLine("El total a pagagar es " + precioConDescuento);
                                    Usuario generic = new Usuario(name, lastName, starTime, endTime, precioConDescuento);
                                    Usuario cliente = new Usuario(name, lastName);
                                    i.User = generic;
                                    i.SumaImportes += precioConDescuento;
                                    theCheapest.Recaudacion += precioConDescuento;
                                    theCheapest.agregaCliente(cliente);
                                    maquinasDisponible--;
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese el nombre del usuario");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Ingrese su apellido");
                                    string lastName = Console.ReadLine();
                                    double montoApagar = horaTotal * theCheapest.PrecioHora;
                                    Console.WriteLine("El total a pagagar es " + montoApagar);
                                    Usuario generic = new Usuario(name, lastName, starTime, endTime, montoApagar);
                                    Maquina motherMachine = new Maquina(chairNum, generic, 0);
                                    motherMachine.SumaImportes += montoApagar;
                                    theCheapest.Recaudacion += montoApagar;
                                    theCheapest.agregaMaquina(motherMachine);
                                    theCheapest.agregaCliente(generic);
                                    maquinasDisponible--;
                                    
                                }
                            }
                        }
                        catch (todosLugaresOcupadosException)
                        {
                            Console.WriteLine("Lo sentimos , todos lo lugares se encuentran ocupados,vuelva mas tarde");
                        }
                        catch (lugarDeseadoOcupadoException)
                        {
                            Console.WriteLine("El lugar que eligio se encuentra ocupado, lo sentimos");
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Ocurrio un error inesperado , intenre denuevo");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Ingrese el numero de maquina a liberar");
                            int numM = int.Parse(Console.ReadLine());
                            bool exist = false; 

                            foreach (Maquina i in theCheapest.Maquinas)
                            {
                                if (i.NumeroMaquina == numM)
                                {
                                    Console.WriteLine("El monto cobrado es " + i.User.ImporteAbonar);
                                    i.SumaImportes += i.User.ImporteAbonar;
                                    i.User = null;
                                    exist = true;
                                }                               
                            }
                            if (exist == false)
                            {
                                Console.WriteLine("Maquina no encontrada");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("El tipo de dato introducido no es correcto");
                        }
                        break;

                    case 3:

                        foreach (Maquina i in theCheapest.Maquinas)
                        {
                            Console.WriteLine("El numero de de importes de la maquina " + i.NumeroMaquina + " es " + i.SumaImportes);
                        }
                        break;

                    case 4:
                        Console.WriteLine("El total recaudado por el ciber es:" + theCheapest.Recaudacion);
                        break;
                    case 5:
                        try
                        {
                            Console.WriteLine("Ingrese su nombre");
                            string namae = Console.ReadLine();
                            Console.WriteLine("Ingrese su apellido");
                            string apelle = Console.ReadLine();
                            Usuario ek = new Usuario(namae, apelle);
                            theCheapest.agregaCliente(ek);
                            Console.WriteLine("Usuario añadido correctamente");
                            break;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("El tipo de dato introducido no es correcoto");
                        }
                        break;
                    case 6:
                        foreach (Usuario i in theCheapest.Clientes)
                        {
                            Console.WriteLine("cliente: " + i.Nombre + " " + i.Apellido);
                        }
                        break;

                    case 7:
                        try
                        {
                            Console.WriteLine("Ingrese el apellido del usuario que quiere eliminar");
                            string apel = Console.ReadLine();

                            foreach (Usuario i in theCheapest.Clientes)
                            {
                                if (i.Apellido == apel)
                                {
                                    theCheapest.eliminaCliente(i);
                                    Console.WriteLine("Eliminado satisfactoriamente");
                                    break;
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("El tipo de dato introducido no es correcto");
                        }
                        break;
                    case 8:
                        bool libre = true;
                        foreach (Maquina i in theCheapest.Maquinas)
                        {
                            if (i.User != null)
                            {
                                Console.WriteLine("La maquina " + i.NumeroMaquina + " se encuentra ocupada");
                                libre = false;
                            }
                        }
                        if (libre == true)
                        {
                            Console.WriteLine("No se encontraron maquinas ocupadas");
                        }
                        break;
                }
                Console.WriteLine("para salir presione enter , para continuar ingrese cualquier valor");
                saliOno = Console.ReadLine();
            }
        }
    }
}
