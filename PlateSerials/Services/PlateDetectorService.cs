using Newtonsoft.Json;
using PlateSerials.Dtos;
using PlateSerials.Helpers;
using PlateSerials.Statics;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlateSerials.Services
{
    public class PlateDetectorService
    {
        private readonly RestClient _client;
        public PlateDetectorService()
        {
            var url = StaticDatas.JsonFileUrl.GetJsonValue("DetectionUrl");
            _client = new RestClient($"{url}/plateTracker");
        }
        public async Task<LoginResponseDto> LoginAysnc(LoginRequestDto model)
        {
            var request = new RestRequest("/user/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(model);
            try
            {
                RestResponse response = await _client.ExecuteAsync(request);

                var content = JsonConvert.DeserializeObject<LoginResponseDto>(response.Content);
                return content;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<PlateDetectionResponseDto>> DetectPlateSerials(string token)
        {
            var request = new RestRequest("/detection/listByOrganization", Method.Get);

            request.AddParameter("pageNumber", 0);
            request.AddParameter("pageSize", 1);
            request.AddHeader("authorization", $"Bearer {token}");

            try
            {
                var response = await _client.GetAsync(request);

                var content = JsonConvert.DeserializeObject<List<PlateDetectionResponseDto>>(response.Content);
                return content;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<PlateDetectionResponseDto> LastPlateSerial(string token)
        {
            var request = new RestRequest("/detection/listByOrganization", Method.Get);

            request.AddParameter("pageNumber", 0);
            request.AddParameter("pageSize", 1);
            request.AddHeader("authorization", $"Bearer {token}");

            try
            {
                var response = await _client.GetAsync(request);

                var content = JsonConvert.DeserializeObject<List<PlateDetectionResponseDto>>(response.Content);
                return content.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
