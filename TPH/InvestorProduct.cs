namespace TPT
{
    public class InvestorProduct
    {
        public long Id { get; set; }
        public string InvestorProductType { get; set; }
        public string Status { get; set; }
        public decimal PlanValue { get; set; }
    }

    public class SippInvestorProduct : InvestorProduct
    {
        public string OperationalStatus { get; set; }
    }
}