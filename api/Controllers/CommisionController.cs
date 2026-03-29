using AvalphaTechnologies.CommissionCalculator.Models;
using AvalphaTechnologies.CommissionCalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvalphaTechnologies.CommissionCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommisionController : ControllerBase
    {
        #region Construction

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="commissionService">The commision service</param>
        public CommisionController(ICommissionService commissionService)
        {
            _commissionService = commissionService;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Calculates the commision
        /// </summary>
        /// <param name="calculationRequest">The commision request object</param>
        /// <returns>Return commisoon response object</returns>
        [ProducesResponseType(typeof(CommissionCalculationResponse), 200)]
        [HttpPost]
        public IActionResult Calculate(CommissionCalculationRequest calculationRequest)
        {
            try
            {
                CommissionCalculationResponse calculationResponse = _commissionService.CalculationCommission(calculationRequest);
                return Ok(calculationResponse);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new 
                {
                    Message = "An internal server error occurred. Please try again later."
                });
            }
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The commision service instance.
        /// </summary>
        private readonly ICommissionService _commissionService;

        #endregion
    }
}
