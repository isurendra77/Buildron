using System;

namespace Buildron.Domain
{
    /// <summary>
    /// Arguments for user updated events.
    /// </summary>
    public class UserUpdatedEventArgs : UserEventArgsBase
	{
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Buildron.Domain.UserUpdatedEventArgs"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public UserUpdatedEventArgs(User user)
			: base (user)
		{
		}
        #endregion
	}
}