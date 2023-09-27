﻿namespace MyShopping.Web.Services.Contract
{
    public interface ITokenProvider
    {
        void SetToken(string token);

        string? GetToken();

        void ClearToken();
    }
}
