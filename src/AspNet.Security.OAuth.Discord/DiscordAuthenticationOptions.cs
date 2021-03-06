/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OAuth.Discord {
    /// <summary>
    /// Defines a set of options used by <see cref="DiscordAuthenticationHandler"/>.
    /// </summary>
    public class DiscordAuthenticationOptions : OAuthOptions {
        public DiscordAuthenticationOptions() {
            AuthenticationScheme = DiscordAuthenticationDefaults.AuthenticationScheme;
            DisplayName = DiscordAuthenticationDefaults.DisplayName;
            ClaimsIssuer = DiscordAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(DiscordAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = DiscordAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = DiscordAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = DiscordAuthenticationDefaults.UserInformationEndpoint;
        }
    }
}
