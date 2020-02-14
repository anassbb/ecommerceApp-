﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Exceptions
{
    class BasketNotFoundException :Exception
    {
        public BasketNotFoundException(int basketId): base($"No basket found with id {basketId}")
        {

        }
        public BasketNotFoundException(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) :base(info,context)
        {

        }
        public BasketNotFoundException(string message): base(message)
        {

        }
        public BasketNotFoundException(string message, Exception innerException) : base(message,innerException)
        {
        }
    }
}
