namespace TexterLib.Output
{
    public interface IOutput
    {
        void Open();
        void Write(string str);
        void Close();
    }
}
