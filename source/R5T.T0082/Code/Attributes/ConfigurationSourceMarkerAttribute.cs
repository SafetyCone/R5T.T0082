using System;


namespace R5T.T0082
{
    /// <summary>
    /// Marks a type (either interface or class) as being a configuration source. Not inherited.
    /// Also allows specifying that a type is *not* a configuration source. (Useful for decorating extraneous types that also happen to be in a configuration source file.)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public class ConfigurationSourceMarkerAttribute : Attribute
    {
        private readonly bool zIsConfigurationSource;
        public bool IsConfigurationSource
        {
            get
            {
                return this.zIsConfigurationSource;
            }
        }


        public ConfigurationSourceMarkerAttribute(
            bool isConfigurationSource = true)
        {
            this.zIsConfigurationSource = isConfigurationSource;
        }
    }
}
