﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvalidTableCountException.cs" company="DHGMS Solutions">
//   Copyright 2004-2014 DHGMS Solutions.
//      
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//      
//   http://www.apache.org/licenses/LICENSE-2.0
//      
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <summary>
//   Exception for when the run set hasn't been specified in the command line arguments
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Dhgms.DataManager.Model.Exception
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception for when the run set hasn't been specified in the command line arguments
    /// </summary>
    [Serializable]
    public class NullRunSetNameException : Exception
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// </summary>
        public NullRunSetNameException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        public NullRunSetNameException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// </summary>
        /// <param name="message">
        /// Exception Message
        /// </param>
        /// <param name="innerException">
        /// Inner Exception
        /// </param>
        public NullRunSetNameException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullRunSetNameException"/> class. 
        /// Constructor
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Context
        /// </param>
        protected NullRunSetNameException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}
