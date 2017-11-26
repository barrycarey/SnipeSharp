using SnipeSharp;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.Models;
using SnipeSharp.Endpoints.SearchFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }


        public static void test()
        {
            SnipeItApi snipe = new SnipeItApi();
            snipe.ApiSettings.ApiToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjY3OGUyM2ZmZjA3NWIxYzAzNjIxNjM1ZDNkZjZmOGE2MjgwNTlhNGI2ZjEwNThkMzJlN2FlYjJhMWEyZTgxNzM0MDEwMTBmMGIxYjBjM2ZhIn0.eyJhdWQiOiIxIiwianRpIjoiNjc4ZTIzZmZmMDc1YjFjMDM2MjE2MzVkM2RmNmY4YTYyODA1OWE0YjZmMTA1OGQzMmU3YWViMmExYTJlODE3MzQwMTAxMGYwYjFiMGMzZmEiLCJpYXQiOjE1MTExNDU0NTgsIm5iZiI6MTUxMTE0NTQ1OCwiZXhwIjoxNTQyNjgxNDU4LCJzdWIiOiIxIiwic2NvcGVzIjpbXX0.RFDCOjEi0UsTP-Yq0mokxoXXnwogUooEF0ce3wFa_3ns61NDO6LKskPE5wCoXRxzOQsdHaWHsfSYBcwG5gh7CmH-H_Bq1fCcspAGI6K9kSIDfCNyEZlZ2A8C1_s5fLQXA7FWXqN1nCd-_TSPzxZcQwXLyj2FomDdIy3y-zGkXmPqNRhoc3Txs6hQ3Bw3n1wiSrUYTiPZVZyFbcJJLJwHC0-Nyy-6_WiKw_P2K24xiz4NXFaYrjDXNxe0nk_iLWS941uUNzcKnLCeAs16sGrA3S5JMqbJN41b9Rl31SF94oCDf9IENlrRhJC0aqcoDCo1xDFCEgxOAtPJp18UJKvImYfzMKhY-u6EdDtLmEUfSoCwbHepNN04btIG4QWrKp4WFGV9eALfguNcbldTOsni_lDrswRGjuIpY4_-uGty8HEFNTDzrQ7izIeYzllxq96idHbI7dIfpMK8NMCARmatPs1tPawXy1OXsWjVj4xAZyg3-ne-xG7YhMIqeKHwTnWB7lYaDDR6MoGDLqSAPpbNDJl10Dx0UKCZNDN5dDLLV2SLWM50ct5ysWSL7f3XHfkeeOBW6XxKqOeAVV39U24P2z7phHCgGx25GxzRIONRBoklgV6IIxIVMBOtE8z0FZrt6cn9Q9bfS8LDg098-oH6uFvLutXZM31Bsz8UX-RuNIg";
            snipe.ApiSettings.BaseUrl = new Uri("http://plex.ho.me/api/v1/");

            AssetSearchFilter filter = new AssetSearchFilter()
            {
                Manufacturer = snipe.ManufacturerManager.Get("Lenovo") as Manufacturer
            };


            List<ICommonEndpointObject> test = (snipe.AssetManager.GetAll().Rows).Where(i => i.Name == "test").ToList();

            Console.ReadKey();

        }
    }
}
