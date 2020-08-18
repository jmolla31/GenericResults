using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericResults
{
    /// <summary>
    /// Generic result class that represents a result value and it's error/s
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TError"></typeparam>
    public class GenericResult<T,TError>
    {
        /// <summary>
        /// Create a new result instance with the provided result value
        /// </summary>
        /// <param name="result"></param>
        public GenericResult(T result) => this.Result = result;

        /// <summary>
        /// Create a new result insatnce with a single error value
        /// </summary>
        /// <param name="singleError"></param>
        public GenericResult(TError singleError) => this.Errors = new TError[1] { singleError };

        /// <summary>
        /// Createa a new result insatnce with a set of error values
        /// </summary>
        /// <param name="errors"></param>
        public GenericResult(IEnumerable<TError> errors) => this.Errors = errors;

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();

        public T Result { get; }

        public bool Succeeded => !this.Errors.Any();
    }

    /// <summary>
    /// Generic result class that represents a result value, warnings and errors
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TWarning"></typeparam>
    /// <typeparam name="TError"></typeparam>
    public class GenericResult<T, TWarning, TError>
    {
        /// <summary>
        /// Create a new result instance with the provided result value
        /// </summary>
        /// <param name="result"></param>
        public GenericResult(T result) => this.Result = result;

        /// <summary>
        /// Create a new result insatnce with a single error value
        /// </summary>
        /// <param name="singleError"></param>
        public GenericResult(TError singleError) => this.Errors = new TError[1] { singleError };


        /// <summary>
        /// Createa a new result insatnce with a set of warning values
        /// </summary>
        /// <param name="errors"></param>
        public GenericResult(IEnumerable<TWarning> warnings) => this.Warnings = warnings;


        /// <summary>
        /// Createa a new result insatnce with a set of warning and error values
        /// </summary>
        /// <param name="errors"></param>
        public GenericResult(IEnumerable<TWarning> warnings, IEnumerable<TError> errors)
        {
            this.Warnings = warnings;
            this.Errors = errors;
        }

        public IEnumerable<TError> Errors { get; } = Enumerable.Empty<TError>();
        public IEnumerable<TWarning> Warnings { get; } = Enumerable.Empty<TWarning>();

        public T Result { get; }

        public bool Succeeded => !this.Errors.Any();
        public bool HasWarnings => this.Warnings.Any();
    }
}
