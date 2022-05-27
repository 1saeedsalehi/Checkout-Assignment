namespace Checkout.Core.Exceptions;

internal class CheckoutExceptionBase : Exception
{


    public CheckoutExceptionBase(string message, string technicalMessage = "", int? errorCode = null)
        : base(message)
    {
        ErrorCode = errorCode;
        TechnicalMessage = technicalMessage;
    }

    public CheckoutExceptionBase(string message, string technicalMessage, Exception innerException, int? errorCode = null)
        : base(message, innerException)
    {
        ErrorCode = errorCode;
        TechnicalMessage = technicalMessage;
    }

    /// <summary>
    /// An arbitrary error code.
    /// </summary>
    public int? ErrorCode { get; protected set; }

    /// <summary>
    /// Technical-details are not allowed to be shown to the user.
    /// Just log them or use them internally by software-technicians.
    /// </summary>
    public string TechnicalMessage { get; protected set; }



}

