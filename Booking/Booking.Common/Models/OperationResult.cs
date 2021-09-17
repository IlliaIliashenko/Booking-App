namespace Booking.Common.Models
{
    public struct OperationResult<T>
    {
        public bool IsSuccess { get; init; }
        public T Result { get; init; }
        public string ErrorMessage { get; init; }

        public static OperationResult<T> Success { get; } = new OperationResult<T> { IsSuccess = true };

        public static OperationResult<T> FromResult(T result)
        {
            return new OperationResult<T> { IsSuccess = true, Result = result };
        }

        public static OperationResult<T> FromError(string errorMessage)
        {
            return new OperationResult<T> { ErrorMessage = errorMessage };
        }
    }
}