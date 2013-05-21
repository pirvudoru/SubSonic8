﻿namespace Client.Tests.Mocks
{
    using System.Collections.Generic;
    using Client.Common.Results;

    public class MockCreatePlaylistResult : MockServiceResultBase<bool>, ICreatePlaylistResult
    {
        #region Public Properties

        public string Name { get; private set; }

        public IEnumerable<int> SongIds { get; private set; }

        #endregion
    }
}