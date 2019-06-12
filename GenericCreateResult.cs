﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericResults
{
    public class GenericCreateResult<T>
    {
        public GenericCreateResult(T result) => this.Result = result;

        public GenericCreateResult(IEnumerable<string> errors) => this.Errors = errors;

        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        public T Result { get; }

        public bool Succeeded => !this.Errors.Any();
    }
}