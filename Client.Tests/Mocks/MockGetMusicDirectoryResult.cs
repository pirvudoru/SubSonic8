﻿namespace Client.Tests.Mocks
{
    using Client.Common.Models.Subsonic;
    using Client.Common.Results;
    using global::Common.Mocks;

    public class MockGetMusicDirectoryResult : MockServiceResultBase<MusicDirectory>, IGetMusicDirectoryResult
    {
    }
}