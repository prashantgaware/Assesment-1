using AvalphaTechnologies.CommissionCalculator.Models;

namespace AvalphaTechnologies.CommissionCalculator.Services
{
    /// <summary>
    /// Reprsents commision service class
    /// </summary>
    public class CommissionService : ICommissionService
    {
        /// <summary>
        /// Calculates the commision
        /// </summary>
        /// <param name="commissionCalculationRequest">The commision request object</param>
        /// <returns>The commison response object</returns>
        /// <exception cref="ArgumentException">The exception</exception>
        public CommissionCalculationResponse CalculationCommission(CommissionCalculationRequest commissionCalculationRequest)
        {
            if (commissionCalculationRequest == null || commissionCalculationRequest.LocalSalesCount < 0 ||
                commissionCalculationRequest.ForeignSalesCount < 0 || commissionCalculationRequest.AverageSaleAmount < 0) 
            {
                throw new ArgumentException("Values cannot be less then 0.");
            }

            decimal avalphaLocal = commissionCalculationRequest.LocalSalesCount * commissionCalculationRequest.AverageSaleAmount * AvalphaLocalRate;
            decimal avalphaForeign = commissionCalculationRequest.ForeignSalesCount * commissionCalculationRequest.AverageSaleAmount * AvalphaForeignRate;

            decimal competitorLocal = commissionCalculationRequest.LocalSalesCount * commissionCalculationRequest.AverageSaleAmount * CompetitorLocalRate;
            decimal competitorForeign = commissionCalculationRequest.ForeignSalesCount * commissionCalculationRequest.AverageSaleAmount * CompetitorForeignRate;

            return new CommissionCalculationResponse
            {
                AvalphaTechnologiesCommissionAmount = avalphaLocal + avalphaForeign,
                CompetitorCommissionAmount = competitorLocal + competitorForeign
            };
        }

        #region

        /// <summary>
        /// The avalpha local rate
        /// </summary>
        private const decimal AvalphaLocalRate = 0.20m;

        /// <summary>
        /// The avalpha foreign rate
        /// </summary>
        private const decimal AvalphaForeignRate = 0.35m;

        /// <summary>
        /// The competior local rate
        /// </summary>
        private const decimal CompetitorLocalRate = 0.02m;

        /// <summary>
        /// The competitor foreign rate
        /// </summary>
        private const decimal CompetitorForeignRate = 0.0755m;

        #endregion
    }
}
