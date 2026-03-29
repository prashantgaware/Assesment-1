using System.ComponentModel.DataAnnotations;

namespace AvalphaTechnologies.CommissionCalculator.Models
{
    public class CommissionCalculationRequest
    {
        /// <summary>
        /// Gets or sets the local sale count
        /// </summary>
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Local Sales Count must be 0 or greater.")]
        public int LocalSalesCount { get; set; }

        /// <summary>
        /// Gets or sets the foreign sale count
        /// </summary>
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Foreign Sales Count must be 0 or greater.")]
        public int ForeignSalesCount { get; set; }

        /// <summary>
        /// Gets or sets the avg sale amount
        /// </summary>
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Average Sale Amount must be 0 or greater.")]
        public decimal AverageSaleAmount { get; set; }
    }
}