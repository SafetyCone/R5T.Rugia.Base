using System;


namespace R5T.Rugia.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all platform operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all platfrom operations that are in reality spread throughout interfaces, interface extension methods, and static classes, implementation classes, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IPIatformOperationsListing
    {
        string WindowsPlatformStandardRepresentation { get; } // Done in IPlatformOperator, PlatformOperator, PlatformOperations.
        string NonWindowsPlatformStandardRepresentation { get; } // Done in IPlatformOperator, PlatformOperator, PlatformOperations.

        Platform Platform { get; set; } // Thread-safe. // Done in IPlatformOperator, PlatformOperator, PlatformOperations.
        Platform ExecutingMachinePlatform { get; } // Done in IPlatformOperator, PlatformOperator, PlatformOperations.


        void ResetPlatform(); // Thread-safe. // Done in IPlatformOperator, PlatformOperator, PlatformOperations.
        Platform GetAlternatePlatform(Platform platform); // Done in IPlatformOperator, PlatformOperator, PlatformOperations.

        // String representation.
        Platform ToPlatformFromStandard(string standardPlatformRepresentation); // Done in IPlatformOperator, PlatformOperator, PlatformOperations.
        string ToStringStandard(Platform platform); // Done in IPlatformOperator, PlatformOperator, PlatformOperations.
    }
}
