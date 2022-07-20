using ClosedXML.Excel;

namespace ProjetoLeitorXls.console
{
    public class Program
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        static void Main(string[] args)
        {
            var xls = new XLWorkbook(@"C:\Users\jonat\OneDrive\Área de Trabalho\Dev\ProjetoLeitorPlanilhaXls.xlsx");
            var planilha = xls.Worksheets.First(x => x.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count();

            for (var linha = 2; linha < totalLinhas; linha++)
            {
                var nome = planilha.Cell($"A{linha}").Value.ToString();
                var email = planilha.Cell($"B{linha}").Value.ToString();
                var cpf = planilha.Cell($"C{linha}").Value.ToString();
                var dataNasc = DateTime.Parse(planilha.Cell($"D{linha}").Value.ToString());
                var senha = planilha.Cell($"E{linha}").Value.ToString();
                var urlImagem = planilha.Cell($"F{linha}").Value.ToString();
                
                Usuarios.Add(new Usuario(nome, email, cpf, dataNasc, senha, urlImagem));
            }
            for (int i = 0; i < Usuarios.Count; i++)
            {
                Console.WriteLine($"{Usuarios[i].Nome} - {Usuarios[i].Email} - {Usuarios[i].Cpf} - {Usuarios[i].DataNascimento} - {Usuarios[i].Senha} - {Usuarios[i].UrlImagemCadastro}");
            }
        }
    }
}