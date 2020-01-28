using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResults
{
    /// <summary>
    /// Provided for backwards compatibility, please see obsolete attribute explanation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Obsolete("GenericErrorListResult with only string errors is obsolete, please use new GenericErrorListResult<TError> class")]
    public class GenericErrorListResult
    {
        public GenericErrorListResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; set; }
    }
}
