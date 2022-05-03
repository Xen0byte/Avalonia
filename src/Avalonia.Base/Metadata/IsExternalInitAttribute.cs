﻿#if !NET5_0_OR_GREATER
namespace System.Runtime.CompilerServices
{
    using global::System.Diagnostics;
    using global::System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     Reserved to be used by the compiler for tracking metadata.
    ///     This class should not be used by developers in source code.
    /// </summary>
    /// <remarks>
    ///     This definition is provided by the <i>IsExternalInit</i> NuGet package (https://www.nuget.org/packages/IsExternalInit).
    ///     Please see https://github.com/manuelroemer/IsExternalInit for more information.
    /// </remarks>
    [ExcludeFromCodeCoverage, DebuggerNonUserCode]
    internal static class IsExternalInit
    {
    }
}
#endif