﻿using evaluacionUtcd.Data;
using Enee.IoC.Architecture;
using Oakton;

namespace evaluacionUtcd.Api.Tools.Migrations;

public class RunMigrationUp
{
    public class MigrationUp
    {
    }

    [Description("Migration up", Name = "migration-up")]
    public class MigrationUpCommand : OaktonAsyncCommand<MigrationUp>
    {


        public override Task<bool> Execute(MigrationUp input)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            DbSettings? dbSettings = configuration.GetRequiredSection(DbSettings.ConfigurationSectionName)
                .Get<DbSettings>();
            MigrationStartup.RunMigrations(dbSettings!.PostgresConexion!, dbSettings.SchemaTables!,typeof(DiscoverEfConfigurations).Assembly);
            return Task.FromResult(true);
        }
    }
}
