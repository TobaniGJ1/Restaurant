namespace Restaunt.Web.IOC
{
    public static class Dependency
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            #region "HttClient"
            service.AddHttpClient<ICustomersServices, CustomersServices>();
            service.AddHttpClient<IUsersServices, UsersServices>();
            #endregion

            #region "AddScope"
            service.AddScoped<ICustomersServices, CustomersServices>();
            service.AddScoped<IUsersServices, UsersServices>();
            #endregion

        }
    }
}

