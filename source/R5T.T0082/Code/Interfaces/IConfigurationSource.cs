using System;


namespace R5T.T0082
{
    /// <summary>
    /// Empty marker interface to communicate that that type is a configuration source.
    /// Configuration sources are largely dummy types used to communicate where configuration information can be found.
    /// </summary>
    // Not itself marked with configuration source marker attribute to avoid erroneous identification as a configuration source.
    public interface IConfigurationSource
    {
    }
}