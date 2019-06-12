using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResults
{
    public class GenericDeleteResult
    {
        public GenericDeleteResult() => this.Succeeded = true;

        public GenericDeleteResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; set; }

        public bool Succeeded { get; set; }
    }
}
