// See https://aka.ms/new-console-template for more information
Console.WriteLine("SwitchCase");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");

//  Convert in SwitchCase
Console.WriteLine("Scwitchcase");
switch (product[0])
{
    case "01":
        type = "Sweet Shirt";
        Console.WriteLine(type);
        break;
    case "02":
        type = "T-Shirt";
        Console.WriteLine(type);
        break;
    case "03":
        type = "Sweet Pant";
        Console.WriteLine(type);
        break;
    default:
        type = "other";
        Console.WriteLine(type);
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "L":
        size = "Large";
        break;
    case "M":
        size = "Medium";
        break;
    default:
        size = "All Size Fits";
        break;
}







int employeeLevel = 300;
string employeeName = "Sarfaraz";

string employeeTitle = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        employeeTitle = "Senior Associate";
        break;
    case 300:
        employeeTitle = "Manager";
        break;
        default:
        employeeTitle = "Associate";
        break;
}

Console.WriteLine($"{employeeName} , {employeeTitle}");
