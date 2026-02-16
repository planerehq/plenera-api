using Plenera.Application.DTOs.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenera.Application.Interfaces
{
    public interface IAIService
    {
        Task<AIResponse> GenerateContentAsync(string prompt);
    }

}
