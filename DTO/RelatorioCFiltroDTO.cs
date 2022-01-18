namespace ApiGmaster.DTO
{
    public class RelatorioCFiltroDTO
    {
        public int EmpresaId { get; set; }
        public string Cnpj { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public string Nivel { get; set; }
        public string CodRubrica { get; set; }
        public string DescRubrica { get; set; }
        public decimal ValorVerba { get; set; }
        public decimal ValorPatronal { get; set; }
        public decimal ValorDesoneracao { get; set; }
        public decimal Rat { get; set; }
        public decimal Terceiros { get; set; }
        public decimal TotalSemSelic { get; set; }
        public decimal ValorSelic { get; set; }
        public decimal ValorComSelic { get; set; }
    }
}
