using System.Collections.Generic;

namespace GenericResults
{
    public class GenericDeleteResult
    {
        public GenericDeleteResult() => this.Succeeded = true;

        public GenericDeleteResult(string singleError) => this.Errors = new string[1] { singleError };

        public GenericDeleteResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; set; }

        public bool Succeeded { get; set; }
    }
}
