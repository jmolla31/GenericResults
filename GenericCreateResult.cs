using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericCreateResult<T, TError>
    {
        public GenericCreateResult(T result) => this.Result = result;

        public GenericCreateResult(TError singleError) => this.Errors = new TError[1] { singleError };

        public GenericCreateResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public T Result { get; }

        public bool Succeeded => !this.Errors.Any();
    }
}
