internal class Program
{
    private static void Main(string[] args)
    {
        string degisken = "Dersimiz Csharp. Hoşgeldiniz:";

        //Lenght
        System.Console.WriteLine(degisken.Length);
        
        //ToUpper ToLower
        System.Console.WriteLine(degisken.ToUpper());
        System.Console.WriteLine(degisken.ToLower());

        //Concat
        System.Console.WriteLine(string.Concat(degisken,"Merhaba"));





    }
}