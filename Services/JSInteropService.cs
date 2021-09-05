using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace FerryFinder.Services
{
    public class JSInteropService
    {
		private readonly IJSRuntime iJSRuntime;

		public JSInteropService(IJSRuntime iJSRuntime)
		{
			this.iJSRuntime = iJSRuntime;
		}

		public async ValueTask ReplaceUrl(string url)
		{
			await iJSRuntime.InvokeVoidAsync("jsInterop.replaceUrl", url);
		}

		public async ValueTask SetUrl(string url)
		{
			await iJSRuntime.InvokeVoidAsync("jsInterop.setUrl", url);
		}
    }
}
