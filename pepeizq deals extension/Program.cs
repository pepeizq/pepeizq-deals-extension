﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.BrowserExtension;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using pepeizq_deals_extension.Pages;

namespace pepeizq_deals_extension
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.UseBrowserExtension(browserExtension =>
            {
				if (browserExtension.Mode == BrowserExtensionMode.ContentScript)
				{
					builder.RootComponents.Add<Principal>("#pepeizqdeals");
				}
				else
                {
                    builder.RootComponents.Add<App>("#app");
                    builder.RootComponents.Add<HeadOutlet>("head::after");
                }
            });

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

			await builder.Build().RunAsync();
        }
    }
}
