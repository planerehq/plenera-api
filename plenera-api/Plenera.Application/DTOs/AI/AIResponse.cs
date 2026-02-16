using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenera.Application.DTOs.AI
{
    public class AIResponse
    {
        public bool Success { get; set; }
        public string? Content { get; set; }
        public string? Error { get; set; }
        public string? Provider { get; set; }
    }
}
