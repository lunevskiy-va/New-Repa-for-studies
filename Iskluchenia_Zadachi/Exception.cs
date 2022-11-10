[Serializable]
public class MyException : Exception
{
    public DateTime TimeExcept { get; private set; }
    public MyException() : base("DANGER CHISLO CHETNOE") { TimeExcept = DateTime.Now; }
    public MyException(string message) : base(message) { TimeExcept = DateTime.Now; }

}

