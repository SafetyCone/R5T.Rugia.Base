using System;


namespace R5T.Rugia
{
    /// <summary>
    /// Provides indirection for explicit expression of the platform (Windows or non-Windows) on which code is running.
    /// </summary>
    public interface IPlatformOperator
    {
        /// <summary>
        /// Provides the standard Windows platform representation, <see cref="Base.Constants.WindowsPlatformStandardRepresentation"/>.
        /// </summary>
        string WindowsPlatformStandardRepresentation { get; }
        /// <summary>
        /// Provides the standard non-Windows platform representation, <see cref="Base.Constants.NonWindowsPlatformStandardRepresentation"/>.
        /// </summary>
        string NonWindowsPlatformStandardRepresentation { get; }


        /// <summary>
        /// Allows explicitly getting/setting the platform for use in all client code.
        /// Thread-safe.
        /// </summary>
        Platform Platform { get; set; }
        /// <summary>
        /// The actual platform value for the machine on which code is currently executing.
        /// The value is produced by <see cref="Base.Utilities.GetExecutingMachinePlatform"/>.
        /// </summary>
        Platform ExecutingMachinePlatform { get; }


        /// <summary>
        /// Sets the <see cref="IPlatformOperator.Platform"/> to the value produced by <see cref="Base.Utilities.GetExecutingMachinePlatform"/>.
        /// Thread-safe.
        /// </summary>
        void ResetPlatform();

        /// <summary>
        /// Given one <see cref="Rugia.Platform"/> value, get the other.
        /// </summary>
        Platform GetAlternatePlatform(Platform platform);

        // String representation.
        /// <summary>
        /// Converts a string containing one of the standard platform representations into a <see cref="Rugia.Platform"/> value.
        /// </summary>
        Platform ToPlatformFromStandard(string standardPlatformRepresentation);
        /// <summary>
        /// Converts a <see cref="Rugia.Platform"/> value into its standard string representation.
        /// </summary>
        string ToStringStandard(Platform platform);
    }
}
