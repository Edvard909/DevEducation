namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = new string[4]; 

            for (int i = 0; i < inputs.Length; i++)
            {
                string newInput = Console.ReadLine();

                inputs[i] = newInput;
            }

            string[,] outputs = new string[4, 4];
            
                for (int i = 0; i < outputs.Length; i++) 
            {
                outputs[0, i] = "a";
            } 
            
        }
    }
}