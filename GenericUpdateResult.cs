using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericUpdateResult
    {
        public GenericUpdateResult() => this.Succeeded = true;

        public GenericUpdateResult(string singleError) => this.Errors = new string[1] { singleError };

        public GenericUpdateResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        public bool Succeeded { get; }
    }

    public class GenericUpdateResult<TError>
    {
        public GenericUpdateResult() => this.Succeeded = true;

        public GenericUpdateResult(TError singleError) => this.Errors = new TError[1] { singleError };

        public GenericUpdateResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public bool Succeeded { get; }
    }
}
