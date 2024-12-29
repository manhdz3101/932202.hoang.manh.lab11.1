namespace WebApplication1.Models
{
    public class CalcModel
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Add => Num1 + Num2;
        public int Sub => Num1 - Num2;
        public int Mul => Num1 * Num2;
        public int? Div => Num2 != 0 ? Num1 / Num2 : null;
        public string ErrorMessage => Num2 == 0 ? "Division by zero error." : null;
    }
}
