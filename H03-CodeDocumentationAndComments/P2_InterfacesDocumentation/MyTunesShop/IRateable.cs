namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface IRateable
    {
        /// <summary>
        /// Gets the ratings.
        /// </summary>
        /// <value>
        /// The ratings.
        /// </value>
        IList<int> Ratings { get; }

        /// <summary>
        /// Places the rating.
        /// </summary>
        /// <param name="rating">The rating.</param>
        void PlaceRating(int rating);
    }
}
