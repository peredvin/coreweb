using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace coreweb1
{


    public class Startup
    {


        static string webpage =
                    @"<html>
               <body>
                    ingen behandling sker, sidan returneras som det är skriven i html
               </body>
            </html>"
                ;

        static string webpagefixed =
            @"<html>
              <body>
                  <div> Den här sidan har manipulerats på servern innan den sänds tillbaks</div>
                  <script>alert('sidan har manupilerats av kod {0}' ) </script>
              </body>
           </html>"
        ;




        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await myprocessing(context);
            });
        }


        private Task myprocessing(HttpContext context)
        {
            if (context.Request.Query.First().ToString().Contains("hubba"))
                return context.Response.WriteAsync
                    (string.Format(webpagefixed, context.Request.Query.First().ToString()));
            else

                return  context.Response.WriteAsync(webpage); 
            
        }

        

    }
}
