namespace ApiGmaster.DTO
{
    public class RelatorioAnaliticoDto
    {
        public string Cnpj { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Nivel { get; set; }
        public decimal ValorVerba { get; set; }
        public decimal ValorPatronal { get; set; }
        public decimal ValorDesoneracao { get; set; }
        public decimal Rat { get; set; }
        public decimal Terceiros { get; set; }
        public decimal PegaSelic { get; set; }
        public decimal TotalSemSelic => ValorDesoneracao == 0 ? (ValorPatronal + Rat + Terceiros) : ValorDesoneracao + Rat + Terceiros;
        public decimal TaxaSelic { get; set; }
        public decimal ValorSelic => TaxaSelic == 0 ? PegaSelic : TaxaSelic * TotalSemSelic;
        public string Data { get; set; }
        public decimal Total => ValorDesoneracao == 0 ? (ValorPatronal + Rat + Terceiros) + ValorSelic : ValorDesoneracao + Rat + Terceiros + ValorSelic;
    } 
}
