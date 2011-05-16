// Enum.cs
// Script#/Libraries/CoreLib
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System.Runtime.CompilerServices;

namespace System {

    [Imported]
    [ScriptNamespace("ss")]
    public abstract class Enum : ValueType {

        public static Enum Parse(Type type, string s) {
            return null;
        }
    }
}
