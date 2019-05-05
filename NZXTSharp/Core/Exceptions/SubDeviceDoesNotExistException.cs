/*
SubDeviceDoesNotExistException.cs
Copyright (C) 2019  Ari Madian

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NZXTSharp.Exceptions
{
    /// <summary>
    /// Thrown When a user attempts to reference an
    /// <see cref="ISubDevice"/>that does not exist.
    /// </summary>
    public class SubDeviceDoesNotExistException : Exception
    {
        /// <inheritdoc/>
        public SubDeviceDoesNotExistException()
        {

        }

        /// <inheritdoc/>
        public SubDeviceDoesNotExistException(string message)
            : base(message)
        {

        }

        /// <inheritdoc/>
        public SubDeviceDoesNotExistException(string message, Exception innerException) : 
            base(message, innerException)
        {
        }
    }
}
