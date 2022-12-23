
using ConsoleApp1;
using ConsoleApp1.Exceptions;

try
{
	var lead = new Lead("Luiz", "Felipe");
	//lead.ChangeName("Pedro", "Afonso");

	Console.WriteLine(lead.Name);
	Console.WriteLine(lead.FirstName);
	Console.WriteLine(lead.LastName);
	Console.WriteLine(lead.Email);
	Console.WriteLine(lead.NormalizedEmail);
}
catch (InvalidEmailException ex)
{
	Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}


