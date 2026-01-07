namespace AvalphaTechnologies.CommissionCalculator.Models
{
    /// <summary>
    /// Represents commision cal response
    /// </summary>
    public class CommissionCalculationResponse
    {
        /// <summary>
        /// Gets or sets the avalpha tech commision amunt
        /// </summary>
        public decimal AvalphaTechnologiesCommissionAmount { get; set; }

        /// <summary>
        /// Gets or sets the competitor commision amunt
        /// </summary>
        public decimal CompetitorCommissionAmount { get; set; }
    }
}
