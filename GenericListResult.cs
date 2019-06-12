using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericResults
{
    public class GenericListResult<T>
    {
        public GenericListResult(IReadOnlyCollection<T> result) => this.Result = result;

        public GenericListResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        public IReadOnlyCollection<T> Result { get; }

        public bool Succeeded => !this.Errors.Any();
    }
}
