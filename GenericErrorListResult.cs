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
}
