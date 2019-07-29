using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericBatchResult
    {
        public GenericBatchResult(IEnumerable<string> alerts) => this.Alerts = alerts;

        public IEnumerable<string> Alerts { get; } = Enumerable.Empty<string>();

        public bool Succeeded => !this.Alerts.Any();
    }
}
