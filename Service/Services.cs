namespace WebApplication1.Services
{
    public class CalcService
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public CalcService()
        {
            var random = new Random();
            Num1 = random.Next(0, 11);
            Num2 = random.Next(0, 11);
        }

        public int Add() => Num1 + Num2;
        public int Sub() => Num1 - Num2;
        public int Mul() => Num1 * Num2;
        public int? Div() => Num2 != 0 ? Num1 / Num2 : null;
    }
}
