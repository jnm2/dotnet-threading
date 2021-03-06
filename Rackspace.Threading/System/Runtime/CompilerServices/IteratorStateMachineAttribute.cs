﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

#if NET40PLUS

using System.Runtime.CompilerServices;

[assembly: TypeForwardedTo(typeof(IteratorStateMachineAttribute))]

#else

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Indicates whether a method in Visual Basic is marked with the <see langword="Iterator"/> modifier.
    /// </summary>
    /// <preliminary/>
    [Serializable]
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class IteratorStateMachineAttribute : StateMachineAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IteratorStateMachineAttribute"/> class.
        /// </summary>
        /// <param name="stateMachineType">
        /// The type object for the underlying state machine type that's used to implement a state machine method.
        /// </param>
        public IteratorStateMachineAttribute(Type stateMachineType)
            : base(stateMachineType)
        {
        }
    }
}

#endif
