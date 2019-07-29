using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericUpdateResult
    {
        public GenericUpdateResult() => this.Succeeded = true;

        public GenericUpdateResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        public bool Succeeded { get; }
    }
}
