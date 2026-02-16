using Plenera.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenera.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; } = default!;
        public string Email { get; private set; } = default!;
    }
}
