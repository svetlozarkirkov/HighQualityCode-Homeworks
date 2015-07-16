namespace MyTunesShop
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public interface ISong : IMedia, IRateable
    {
        /// <summary>
        /// Gets the performer.
        /// </summary>
        /// <value>
        /// The performer.
        /// </value>
        IPerformer Performer { get; }

        /// <summary>
        /// Gets the genre.
        /// </summary>
        /// <value>
        /// The genre.
        /// </value>
        string Genre { get; }

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        int Year { get; }

        /// <summary>
        /// Gets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        string Duration { get; }
    }
}
