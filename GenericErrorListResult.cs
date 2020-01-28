using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResults
{
    public class GenericErrorListResult<TError>
    {
        public GenericErrorListResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; set; }
    }
}
