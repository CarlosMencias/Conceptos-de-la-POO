using Logica;

try
{
    var empleado1 = new SalaryEmployes()
    {
        Id = 1010,
        FirsName = "Carlos",
        LastName = "Mencias",
        BornDate = new Date(1993, 5, 23),
        HireDate = new Date(2023, 5, 10),
        IsActive = true,
        Salary = 600
    };
    var empleado2 = new HourEmployes()
    {
        Id = 2020,
        FirsName = "Alexis",
        LastName = "Sánchex",
        BornDate = new Date(1993, 5, 23),
        HireDate = new Date(2022, 5, 1),
        IsActive = true,
        HourValue = 8,
        WorkingValue = 40
    };
    var empleado3 = new ComissionEmploye()
    {
        Id = 3030,
        FirsName = "MIchelle",
        LastName = "Vaca",
        BornDate = new Date(1996, 3, 23),
        HireDate = new Date(2021, 4, 1),
        IsActive = true,
        ComissionPercentaje = 0.5f,
        Sales = 0
    };
    var empleado4 = new BaseCommisionEmploye()
    {
        Id = 4040,
        FirsName = "Jorge",
        LastName = "Yánez",
        BornDate = new Date(1998, 3, 23),
        HireDate = new Date(2020, 3, 12),
        IsActive = true,
        ComissionPercentaje = 0.25f,
        Sales = 3050,
        Salary = 200
    };

    // Invoices

    var invoce1 = new Invoice()
    {
        Id = 00034,
        Description = "Mac Pro",
        Precie = 1500,
        Quantity = 3
    };
    var invoce2 = new Invoice()
    {
        Id = 00034,
        Description = "Xaommy",
        Precie = 500,
        Quantity = 30
    };
    var invoce3 = new Invoice()
    {
        Id = 00034,
        Description = "Impresoras",
        Precie = 200,
        Quantity = 12
    };

    // Imprsiones

    Employes[] empleados = new Employes[]
    {
        empleado1, empleado2, empleado3, empleado4
    };

    decimal totalAPagar = 0;
    decimal totalIngresos = 0;

    foreach (Employes empleado in empleados)
    {
        Console.WriteLine(empleado);
        totalAPagar += empleado.GetValueToPay();

        if (empleado is ComissionEmploye comissionEmployee)
        {
            totalIngresos += comissionEmployee.Sales;
        }
    }

    Console.WriteLine($"                                ======================");
    Console.WriteLine($"Total a pagar                     {totalAPagar,20:C2}");

    Console.WriteLine($"======================================================");

    decimal totalFacturas = 0;
    Invoice[] invoices = new Invoice[]
    {
        invoce1, invoce2, invoce3
    };

    foreach (Invoice invoice in invoices)
    {
        Console.WriteLine(invoice);
        totalFacturas += invoice.GetValueToPay();
    }

    Console.WriteLine($"                                ======================");
    Console.WriteLine($"Total Facturas                    {totalFacturas,20:C2}\n");

    //Tarea semana 3
    Console.WriteLine($"======================================================");
    decimal egresos = totalAPagar + totalFacturas;
    decimal ganancias = totalIngresos - egresos;

    Console.WriteLine($"                                ======================");
    Console.WriteLine($"Total egresos de la empresa       {egresos,20:C2}\n");

    Console.WriteLine($"                                ======================");
    Console.WriteLine($"Total ingresos                    {totalIngresos,20:C2}");

    Console.WriteLine($"                                ======================");
    Console.WriteLine($"Total Ganancias de la empresa     {ganancias,20:C2}");


    // Implemetar los egresos de la empresa
    // Implementar los ingresos que genrera el total de vendedores por commision
    // Va a restar los ingresos - egresos

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}