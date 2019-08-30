﻿namespace Application
{
    using Framework.DataAccessLayer;
    using Framework.Json;
    using System.Threading.Tasks;

    public class AppMain : AppJson
    {
        public AppMain() : this(null) { }

        public AppMain(ComponentJson owner) : base(owner) { }

        protected override async Task InitAsync()
        {
            if (this.IsSessionExpired)
            {
                this.BootstrapAlert(sessionExpired, "Session expired!", BootstrapAlertEnum.Warning);
            }

            bool isDemoPage = true;

            if (isDemoPage == false)
            {
                await this.ComponentPageShowAsync<PageAirplane>();
                await this.ComponentPageShowAsync<PageCountry>();
            }
            else
            {
                await this.ComponentPageShowAsync<PageDemo>();
            }

            new Html(this).TextHtml = "Build 2019-08-18";
        }

        private const string sessionExpired = "SessionExpired";

        protected override Task<bool> GridUpdateAsync(Grid grid, Row row, Row rowNew, DatabaseEnum databaseEnum)
        {
            return base.GridUpdateAsync(grid, row, rowNew, databaseEnum);
        }

        protected override Task ProcessAsync()
        {
            if (this.ComponentGet(sessionExpired) != null && this.IsSessionExpired == false)
            {
                this.ComponentGet(sessionExpired).ComponentRemove();
            }
            return base.ProcessAsync();
        }
    }
}
