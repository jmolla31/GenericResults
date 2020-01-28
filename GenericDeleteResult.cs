using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericDeleteResult<TError>
    {
        public GenericDeleteResult() => this.Succeeded = true;

        public GenericDeleteResult(TError singleError) => this.Errors = new TError[1] { singleError };

        public GenericDeleteResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; set; } = Enumerable.Empty<TError>();

        public bool Succeeded { get; set; }
    }
}
