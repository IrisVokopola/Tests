using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "localhost:8080";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Starting");
                Console.ReadKey();
                Console.WriteLine("Done");
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage();

            //app.Run(ctx => {
            //    return ctx.Response.WriteAsync("Hiya");
            //});
        }
    }
}
