﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    ///     Unable to parse because more than one unit of the given quantity type had this exact unit abbreviation.
    ///     Example: Length.Parse("1 pt") will throw <see cref="AmbiguousUnitParseException" />, because both
    ///     <see cref="LengthUnit.DtpPoint" /> and
    ///     <see cref="LengthUnit.PrinterPoint" /> have "pt" as their abbreviation.
    /// </summary>
#if WINDOWS_UWP
    internal
#else
    public
#endif
        class AmbiguousUnitParseException : UnitsNetException
    {
        /// <inheritdoc />
        public AmbiguousUnitParseException(string message) : base(message)
        {
            HResult = 2;
        }

        /// <inheritdoc />
        public AmbiguousUnitParseException(string message, Exception innerException) : base(message, innerException)
        {
            HResult = 2;
        }
    }
}
