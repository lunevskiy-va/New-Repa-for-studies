[Serializable]
public class MyException : Exception
{
    public DateTime TimeExcept { get; private set; }
    public MyException() : base("DANGER BRO") { TimeExcept = DateTime.Now; }
    public MyException(string message) : base(message) { TimeExcept = DateTime.Now; }

}