namespace Delegate_Invoke.Static_Classes
{
    public static class Run
    {
        public static void RunFunction(Function function, string text)
        {
            function.Invoke(text);
        }
    }
}
