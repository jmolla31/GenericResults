using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericResults
{
    public class GenericBatchResult<TError>
    {
        public GenericBatchResult() => this.Hits = default;

        public GenericBatchResult(int hits) => this.Hits = hits;

        public GenericBatchResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public int Hits { get; set; }

        public bool Succeeded => !this.Errors.Any();
    }

    public class GenericBatchResult<TMessage, TError>
    {
        public GenericBatchResult() => this.Hits = default;

        public GenericBatchResult(int hits) => this.Hits = hits;

        public GenericBatchResult(IEnumerable<TMessage> messages) => this.Messages = messages;

        public GenericBatchResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TMessage> Messages { get; } = Enumerable.Empty<TMessage>();

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public int Hits { get; set; }

        public bool Succeeded => !this.Errors.Any();
    }
}
