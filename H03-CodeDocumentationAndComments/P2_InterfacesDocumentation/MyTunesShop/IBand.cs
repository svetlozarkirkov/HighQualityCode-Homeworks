namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface IBand : IPerformer
    {
        /// <summary>
        /// Gets the members.
        /// </summary>
        /// <value>
        /// The members.
        /// </value>
        IList<string> Members { get; }

        /// <summary>
        /// Adds the member.
        /// </summary>
        /// <param name="memberName">Name of the member.</param>
        void AddMember(string memberName);
    }
}
