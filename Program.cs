using System;
using System.Collections.Generic;

// 1. Skapar UserError
public abstract class UserError
{
    // 2. Abstrakta metoden UEMessage() som ør string.
    public abstract string UEMessage();
}

// 3. Publik klass NumericInputError, inheritance från UserError
public class NumericInputError : UserError
{
    // 4. Override för UEMessage(). Eng. felmeddelande.
    public override string UEMessage()
    {
        return "You tried to use a numeric input in a text only field. This fired an error!";
    }
}

// 5. Skapa en vanlig klass TextInputError som ärver från UserError
public class TextInputError : UserError
{
    // 6. Override. Eng. felmeddelande.
    public override string UEMessage()
    {
        return "You tried to use a text input in a numeric only field. This fired an error!";
    }
}

// 9. Fler klasser för feltyper. Eng. felmeddelande.
public class ConnectionError : UserError
{
    public override string UEMessage()
    {
        return "There was a problem connecting to the server.";
    }
}

public class AuthenticationError : UserError
{
    public override string UEMessage()
    {
        return "Authentication failed. Please check your credentials.";
    }
}

public class TimeoutError : UserError
{
    public override string UEMessage()
    {
        return "The operation timed out.";
    }
}

// Huvudprogram
class Program
{
    static void Main(string[] args)
    {
        // 7. Lista m. UserErrors och instances etc
        List<UserError> userErrors = new List<UserError>
        {
            new NumericInputError(),
            new TextInputError(),
            new ConnectionError(),
            new AuthenticationError(),
            new TimeoutError()
        };

        // 8. Foreach - skriver ut samtl. UserErrors UEMessage()
        foreach (var error in userErrors)
        {
            Console.WriteLine(error.UEMessage());
        }
    }
}