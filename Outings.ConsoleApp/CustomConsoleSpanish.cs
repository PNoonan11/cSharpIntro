using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outings.Repository;

namespace Outings.ConsoleApp
{
    public class CustomConsoleSpanish : ICustomConsole

    {





        public void PrintMainMenu()
        {
            Console.WriteLine("Base de datos de salidas de Komodo\n\n" +
                            "1. Ver todas las salidas.\n" +
                            "2. Costo total de todos los tipos de salidas.\n" +
                            "3. Costo de salida por tipo. \n" +
                            "4. Agregar salida a la base de datos.");
        }
        public void PressAnyKeyToContinue()
        {
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        public void ListAllOutings(List<OutingList> outing)
        {
            foreach (OutingList x in outing)
            {
                PrintMenu(x);
            }
        }
        public void PrintMenu(OutingList outing)
        {
            Console.WriteLine($"Tipo de evento: {outing.TypeOfEvent}\n" +
                            $"Número de asistentes: {outing.NumberOfAttendees}\n" +
                            $"Fecha del evento: {outing.Date}\n" +
                            $"Coste por persona: ${outing.CostPerPerson}\n" +
                            $"Coste Total de la Salida: ${outing.TotalEventCost}\n");
        }

        public void OutingTypeSelectorTotalCost()
        {
            Console.WriteLine("¿Para qué tipo de salida te gustaría ver el costo total?\n" +
                            "1. Salidas de golf.\n" +
                            "2. Salidas de bolos.\n" +
                            "3. Salidas al parque de diversiones..\n" +
                            "4. Salidas de conciertos.\n");
        }

        public void TotalCostOfAllOutingsByType(decimal cost)
        {
            Console.WriteLine($"El costo total de este tipo de salida es: ${cost}\n");
        }
        public void TotalCostOfAllOutings(decimal cost)
        {
            Console.WriteLine($"El costo total de todas las salidas: ${cost}\n");
        }

        public void EventTypeSelectionMenu()
        {
            Console.WriteLine("Seleccione un Tipo para la nueva salida.\n");
            Console.WriteLine("1. Golf.\n" +
                            "2. Bolos.\n" +
                            "3. Parque de diversiones.\n" +
                            "4. Concierto.\n");
        }
        public void NewOutingAttendeeCount()
        {
            Console.WriteLine("¿Cuántas personas asistieron a la salida?:");
        }

        public void NewOutingDateEntry()
        {
            Console.WriteLine("Ingrese la fecha de la Salida (mm/dd/aa):");
        }

        public void NewOutingCostPerPerson()
        {
            Console.WriteLine("Ingrese el costo POR PERSONA de la salida:");
        }
        public void NewOutingAdded(OutingList outing)
        {
            Console.WriteLine($"¡Tu nueva salida {outing.TypeOfEvent} se ha agregado a la base de datos!");
        }

        public void ErrorHasOccurred(Exception e)
        {

            Console.WriteLine("Se ha producido un error:", e.Message);
        }

        public void TitleArt()
        {
            Console.Title = "ASCII Art";
            string title = @"
:::    ::: ::::::::  ::::    ::::   ::::::::  :::::::::   ::::::::  
:+:   :+: :+:    :+: +:+:+: :+:+:+ :+:    :+: :+:    :+: :+:    :+: 
+:+  +:+  +:+    +:+ +:+ +:+:+ +:+ +:+    +:+ +:+    +:+ +:+    +:+ 
+#++:++   +#+    +:+ +#+  +:+  +#+ +#+    +:+ +#+    +:+ +#+    +:+ 
+#+  +#+  +#+    +#+ +#+       +#+ +#+    +#+ +#+    +#+ +#+    +#+ 
#+#   #+# #+#    #+# #+#       #+# #+#    #+# #+#    #+# #+#    #+# 
###    ### ########  ###       ###  ########  #########   ######## ";
            Console.WriteLine(title);
            Console.WriteLine("SISTEMA DE GESTIÓN DE SALIDAS\n");
            PressAnyKeyToContinue();
            Clear();


        }






        public void Clear()
        {
            Console.Clear();
        }
        public void InvalidInput()
        {
            Console.WriteLine("Invalid input received, returning to main menu...");
        }






    }//class
}//namespace

