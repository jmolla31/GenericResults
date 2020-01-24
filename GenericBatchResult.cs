using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericBatchResult
    {
        public GenericBatchResult(int hits) => this.Hits = hits;

        public GenericBatchResult(IEnumerable<string> alerts) => this.Alerts = alerts;

        public IEnumerable<string> Alerts { get; } = Enumerable.Empty<string>();

        public int Hits { get; set; } 

        public bool Succeeded => !this.Alerts.Any();
    }

    public class GenericBatchResult<TError>
    {
        public GenericBatchResult(int hits) => this.Hits = hits;

        public GenericBatchResult(IEnumerable<TError> alerts) => this.Alerts = alerts;

        public IEnumerable<TError> Alerts { get; } = Enumerable.Empty<TError>();

        public int Hits { get; set; }

        public bool Succeeded => !this.Alerts.Any();
    }
}
