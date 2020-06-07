namespace BusinessCard.Infrastructure.Enums
{
    public enum CustomStatusCode
    {
        #region CustomOkCode
        Ok = 1000,
        #endregion

        #region CustomErrorCode
        UnhandledError = 2000,
        DatabaseError = 2001,
        InvalidGuid = 2002
        #endregion
    }
}
