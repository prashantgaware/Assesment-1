using AvalphaTechnologies.CommissionCalculator.Models;

namespace AvalphaTechnologies.CommissionCalculator.Services
{
    /// <summary>
    /// The commison service interface
    /// </summary>
    public interface ICommissionService
    {
        /// <summary>
        /// Calculates rhe commision
        /// </summary>
        /// <param name="commissionCalculationRequest">Commision request object</param>
        /// <returns>The commision response</returns>
        CommissionCalculationResponse CalculationCommission(CommissionCalculationRequest commissionCalculationRequest);
    }
}
