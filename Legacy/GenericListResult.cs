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
    [Obsolete("GenericListResult with only string errors is obsolete, please use new GenericListResult<T, TError> class")]
    public class GenericListResult<T>
    {
        public GenericListResult(IEnumerable<T> result) => this.Result = result;

        public GenericListResult(string singleError) => this.Errors = new string[1] { singleError };

        public GenericListResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        public IEnumerable<T> Result { get; }

        public bool Succeeded => !this.Errors.Any();
    }
}
