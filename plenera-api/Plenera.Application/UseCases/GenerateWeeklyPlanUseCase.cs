using Plenera.Application.DTOs.AI;
using Plenera.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenera.Application.UseCases
{
    public class GenerateWeeklyPlanUseCase
    {
        private readonly IAIService _aiService;

        /// <summary>
        /// Constructor for GenerateWeeklyPlanUseCase, injecting the AI service dependency.
        /// </summary>
        /// <param name="aiService"></param>
        public GenerateWeeklyPlanUseCase(IAIService aiService)
        {
            _aiService = aiService;
        }

        /// <summary>
        /// Generates a weekly meal plan based on user preferences using the AI service.
        /// </summary>
        /// <param name="preferences"></param>
        /// <returns></returns>
        public async Task<AIResponse> ExecuteAsync(string preferences)
        {
            var prompt = $"Generate weekly meal plan for: {preferences}";

            var response = await _aiService.GenerateContentAsync(prompt);

            if (!response.Success)
                throw new Exception("AI generation failed");

            return response;
        }
    }
}
