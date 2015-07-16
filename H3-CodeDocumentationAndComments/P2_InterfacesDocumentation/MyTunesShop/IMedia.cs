namespace MyTunesShop
{
    using System;

    /// <summary>
    /// </summary>
    public interface IMedia
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string Title { get; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        decimal Price { get; }
    }
}
