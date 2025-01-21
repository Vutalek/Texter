namespace TexterLib.Input
{
    public interface IInput
    {
        void Open();
        string ReadLine();
        void Close();
    }
}
