using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResults
{
    /// <summary>
    /// Provided for backwards compatibility, please see obsolete attribute explanation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Obsolete("GenericDeleteResult with only string errors are obsolete, please use new GenericDeleteResult<TError> class")]
    public class GenericDeleteResult
    {
        public GenericDeleteResult() => this.Succeeded = true;

        public GenericDeleteResult(string singleError) => this.Errors = new string[1] { singleError };

        public GenericDeleteResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; set; }

        public bool Succeeded { get; set; }
    }
}
