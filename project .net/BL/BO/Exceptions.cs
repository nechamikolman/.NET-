using System;

namespace BO
{
    [Serializable]
    public class BlIdNotExsistException : Exception
    {
        public BlIdNotExsistException(string message) : base(message) { }
        public BlIdNotExsistException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BlIdExsistException : Exception
    {
        public BlIdExsistException(string message) : base(message) { }
        public BlIdExsistException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BlFileNotExsistException : Exception
    {
        public BlFileNotExsistException(string message) : base(message) { }
        public BlFileNotExsistException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BlCustomerNotExsistException : Exception
    {
        public BlCustomerNotExsistException(string message) : base(message) { }
        public BlCustomerNotExsistException(string message, Exception innerException) : base(message, innerException) { }
    }
    [Serializable]
    public class BlCustomersNotExsistException : Exception
    {
        public BlCustomersNotExsistException(string message) : base(message) { }
        public BlCustomersNotExsistException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BlProductNotExsistException : Exception
    {
        public BlProductNotExsistException(string message) : base(message) { }
        public BlProductNotExsistException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BlSaleNotExsistException : Exception
    {
        public BlSaleNotExsistException(string message) : base(message) { }
        public BlSaleNotExsistException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BlInvalidInputException : Exception
    {
        public BlInvalidInputException(string message) : base(message) { }
        public BlInvalidInputException(string message, Exception innerException) : base(message, innerException) { }
    }

    [Serializable]
    public class BlOperationException : Exception
    {
        public BlOperationException(string message) : base(message) { }
        public BlOperationException(string message, Exception innerException) : base(message, innerException) { }
    }
}