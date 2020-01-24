using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResults
{
    public class GenericErrorListResult
    {
        public GenericErrorListResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; set; }
    }

    public class GenericErrorListResult<TError>
    {
        public GenericErrorListResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; set; }
    }
}
