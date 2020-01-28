using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    /// <summary>
    /// Provided for backwards compatibility, please see obsolete attribute explanation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Obsolete("GenericCreateResult with only string errors are obsolete, please use new GenericCreateResult<T,TError> class")]
    public class GenericCreateResult<T>
    {
        public GenericCreateResult(T result) => this.Result = result;

        public GenericCreateResult(string singleError) => this.Errors = new string[1] { singleError };

        public GenericCreateResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        public T Result { get; }

        public bool Succeeded => !this.Errors.Any();
    }
}
