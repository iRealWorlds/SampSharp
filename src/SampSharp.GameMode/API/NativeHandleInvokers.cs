// SampSharp
// Copyright 2017 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace SampSharp.GameMode.API
{
    /// <summary>
    ///     Contains simple wrapper methods for invoking handles of natives with a set of arguments.
    /// </summary>
    public static class NativeHandleInvokers
    {
        /// <summary>
        ///     Invokes the native <see cref="handle" /> with the specified <see cref="args" />.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>The return value as a float.</returns>
        public static float InvokeHandleAsFloat(int handle, object[] args)
        {
            return Native.Get(handle).InvokeFloat(args);
        }

        /// <summary>
        ///     Invokes the native <see cref="handle" /> with the specified <see cref="args" />.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>The return value as a boolean.</returns>
        public static bool InvokeHandleAsBool(int handle, object[] args)
        {
            return Native.Get(handle).InvokeBool(args);
        }

        /// <summary>
        ///     Invokes the native <see cref="handle" /> with the specified <see cref="args" />.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <param name="args">The arguments.</param>
        public static void InvokeHandleAsVoid(int handle, object[] args)
        {
            Native.Get(handle).Invoke(args);
        }

        /// <summary>
        ///     Invokes the native <see cref="handle" /> with the specified <see cref="args" />.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>The return value.</returns>
        public static int InvokeHandle(int handle, object[] args)
        {
            return Native.Get(handle).Invoke(args);
        }
    }
}