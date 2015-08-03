namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface IAlbum : IMedia
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
        /// Gets the songs.
        /// </summary>
        /// <value>
        /// The songs.
        /// </value>
        IList<ISong> Songs { get; }

        /// <summary>
        /// Adds the song.
        /// </summary>
        /// <param name="song">The song.</param>
        void AddSong(ISong song);
    }
}
