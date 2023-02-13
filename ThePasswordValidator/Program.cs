while (true)
{
	Console.Write("Insert a password Please:");
	string? pa = Console.ReadLine();
	PasswordValidator password =  new PasswordValidator();
	password.IsPasswordValid(pa);
}
public class PasswordValidator
{
    private string _password { get; set; }

	public void IsPasswordValid(string password)
	{
		if (password.Length<6 || password.Length>13) 
		{
			Console.WriteLine("Your password must be at least 6 to 13 characteres long");
			
		}

		bool isUpper = false;
		bool isLower = false;
		bool isDigit = false;
		bool isInvalid = false;

        foreach (char letter in password)
		{
			if(char.IsUpper(letter))
				isUpper = true;
			if(char.IsLower(letter))
				isLower = true;
			if(char.IsDigit(letter))
				isDigit = true;
			if (letter == 'T' || letter == '&')
				isInvalid = true;	
		}

		if(isUpper && isLower && isDigit && !isInvalid)
		{
            _password = password;
		}
		Console.WriteLine("Your password must contain one upper character, lower character and number");
	}
}