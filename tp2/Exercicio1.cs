namespace tp2
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
            string? entrada = Console.ReadLine();

            DateTime nascimento;

            if (!DateTime.TryParseExact(
                entrada,
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out nascimento))
            {
                Console.WriteLine("Data inválida.");
                return;
            }

            DateTime hoje = DateTime.Today;

            if (nascimento > hoje)
            {
                Console.WriteLine("A data de nascimento não pode estar no futuro.");
                return;
            }

            int anos = hoje.Year - nascimento.Year;
            int meses = hoje.Month - nascimento.Month;
            int dias = hoje.Day - nascimento.Day;

            if (dias < 0)
            {
                meses--;

                DateTime mesAnterior = hoje.AddMonths(-1);
                dias += DateTime.DaysInMonth(
                    mesAnterior.Year,
                    mesAnterior.Month
                );
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine(
                $"Sua idade é: {anos} anos, {meses} meses e {dias} dias."
            );
        }
    }
}