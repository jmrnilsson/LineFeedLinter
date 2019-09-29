﻿namespace LineFeedLinter
{
    public interface IChecker
    {
        event ApplicationInformation Error;
        event ApplicationInformation Information;
        event ApplicationInformation Verbose;

        void Check(string path);
    }
}