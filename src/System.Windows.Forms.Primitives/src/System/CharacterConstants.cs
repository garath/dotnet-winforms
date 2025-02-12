﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System
{
    internal static class CharacterConstants
    {
        public static ReadOnlySpan<char> NewLine => new char[] { '\n', '\r' };
    }
}
