using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericResults
{
    public class GenericListResult<T, TError>
    {
        public GenericListResult(IEnumerable<T> result) => this.Result = result;

        public GenericListResult(TError singleError) => this.Errors = new TError[1] { singleError };

        public GenericListResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public IEnumerable<T> Result { get; }

        public bool Succeeded => !this.Errors.Any();
    }
}
