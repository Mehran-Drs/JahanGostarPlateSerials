﻿using Newtonsoft.Json;
using PlateSerials.Dtos;
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
            var url = File.ReadAllText("Url.txt");
            _client = new RestClient($"{url}/plateTracker");
        }
        public async Task<LoginResponseDto> LoginAysnc(LoginRequestDto model)
        {
            var request = new RestRequest("/User/Login", Method.Post);
            
            request.AddBody(model);

            try
            {
                var response = await _client.PostAsync(request);

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