namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface IPerformer
    {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        PerformerType Type { get; }

        /// <summary>
        /// Gets the songs.
        /// </summary>
        /// <value>
        /// The songs.
        /// </value>
        IList<ISong> Songs { get; }
    }
}
