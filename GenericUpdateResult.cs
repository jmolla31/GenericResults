using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericUpdateResult<TError>
    {
        public GenericUpdateResult() => this.Succeeded = true;

        public GenericUpdateResult(TError singleError) => this.Errors = new TError[1] { singleError };

        public GenericUpdateResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public bool Succeeded { get; }
    }

    public class GenericUpdateResult<T, TError>
    {
        public GenericUpdateResult(T result) => this.Result = result;

        public GenericUpdateResult(TError singleError) => this.Errors = new TError[1] { singleError };

        public GenericUpdateResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public T Result;

        public bool Succeeded => !this.Errors.Any();
    }
}
