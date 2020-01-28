using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericResults
{
    /// <summary>
    /// Provided for backwards compatibility, please see obsolete attribute explanation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Obsolete("GenericBatchResult with fixed string alerts is obsolete, please use new GenericBatchResult<TMessage, TError> class")]
    public class GenericBatchResult
    {
        public GenericBatchResult(int hits) => this.Hits = hits;

        public GenericBatchResult(IEnumerable<string> alerts) => this.Alerts = alerts;

        public IEnumerable<string> Alerts { get; } = Enumerable.Empty<string>();

        public int Hits { get; set; }

        public bool Succeeded => !this.Alerts.Any();
    }
}
