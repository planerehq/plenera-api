using Plenera.Application.DTOs.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenera.Infrastructure.AI.Providers
{
    public interface IAIProvider
    {
        string Name { get; }
        Task<AIResponse> TryGenerateAsync(string prompt);
    }
}
