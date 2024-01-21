using Emgu.CV.Dnn;
using Newtonsoft.Json;
using PlateSerials.Dtos;
using PlateSerials.Helpers;
using PlateSerials.Statics;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateSerials.Services
{
    public class TikmentService
    {
        private readonly RestClient _client;
        public TikmentService()
        {
            var url = StaticDatas.JsonFileUrl.GetJsonValue("TikmentUrl");
            _client = new RestClient($"{url}");
        }

        public async Task<ClockingPlateSerialResponseDto> AddClockingByPlateSerial(string plateSerial)
        {
            var request = new RestRequest($"/V1/Ta/Clockings/AddClockingByPlateNumber?plateNumber={plateSerial}", Method.Post);

            try
            {
                RestResponse response = await _client.ExecuteAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var content = JsonConvert.DeserializeObject<ClockingPlateSerialResponseDto>(response.Content);
                    return content;
                }
                else
                {
                    return null;
                }
             
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
