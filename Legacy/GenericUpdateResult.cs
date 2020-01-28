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
    [Obsolete("GenericUpdateResult with only string errors is obsolete, please use new GenericUpdateResult<TError> class")]
    public class GenericUpdateResult
    {
        public GenericUpdateResult() => this.Succeeded = true;

        public GenericUpdateResult(string singleError) => this.Errors = new string[1] { singleError };

        public GenericUpdateResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        public bool Succeeded { get; }
    }
}
